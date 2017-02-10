using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PasswordManager.Models
{
    public class SecurityEntityDbContext: DbContext  
    {  
     public SecurityEntityDbContext(): base()  
      {
          Database.SetInitializer<SecurityEntityDbContext>(new SecurityEntityDbContextInitializer());  
      }  
     public DbSet < SecurityEntity > SecurityEntities
      {  
         get;  
         set;  
      } 
    }  
}