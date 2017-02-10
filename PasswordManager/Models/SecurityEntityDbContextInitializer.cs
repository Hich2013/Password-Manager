using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PasswordManager.Models
{
    public class SecurityEntityDbContextInitializer : DropCreateDatabaseIfModelChanges<SecurityEntityDbContext> 
    {
         protected override void Seed(SecurityEntityDbContext context)  
        {  
            var list = new List < SecurityEntity >  
            {  
                new SecurityEntity  
                {  
                    Application = "App1", Password = "sss123456", CreatedDate= DateTime.UtcNow
                },
                new SecurityEntity  
                {  
                    Application = "App2", Password = "ddd123456", CreatedDate= DateTime.UtcNow
                }
            }; 
 
            list.ForEach(m =>  
            {  
                context.SecurityEntities.Add(m);  
            });  
            context.SaveChanges();  
            base.Seed(context);  
        }  
    }
}