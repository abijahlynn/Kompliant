using Kompliant.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kompliant.Models
{
    public class KompliantContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public KompliantContext() : base("name=KompliantContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public System.Data.Entity.DbSet<Requirement> Requirements { get; set; }
        public System.Data.Entity.DbSet<GoverningBody> GoverningBodies { get; set; }
        public System.Data.Entity.DbSet<Standard> Standards { get; set; }
        public System.Data.Entity.DbSet<Topic> Topics { get; set; }
    
    }
}
