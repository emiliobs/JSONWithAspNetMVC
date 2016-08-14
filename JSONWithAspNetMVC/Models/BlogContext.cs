using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace JSONWithAspNetMVC.Models
{
    public class BlogContext : DbContext
    {
      public BlogContext() : base("DefaultConnection")
        {
        }

        public DbSet<BLog> BLog { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}