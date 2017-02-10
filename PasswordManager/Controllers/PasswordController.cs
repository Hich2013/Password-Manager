using PasswordManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PasswordManager.Controllers
{
    public class PasswordController : ApiController
    {
        SecurityEntityDbContext db = new SecurityEntityDbContext();
        
        // GET api/password  
        [ActionName("get"), HttpGet]
        public IEnumerable<SecurityEntity> GetAll()
        {
            return db.SecurityEntities.ToList();
        }

        // GET api/password/5  
        public SecurityEntity Get(int id)
        {
            return db.SecurityEntities.Find(id);
        }

        // POST api/password  
        public HttpResponseMessage Post(SecurityEntity model)
        {
            if (ModelState.IsValid)
            {
                db.SecurityEntities.Add(model);
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, model);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT api/password/5  
        public HttpResponseMessage Put(SecurityEntity model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, model);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/password/5  
        public HttpResponseMessage Delete(int id)
        {
            SecurityEntity secEty = db.SecurityEntities.Find(id);

            if (secEty == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.SecurityEntities.Remove(secEty);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, secEty);
        }  
    }
}
