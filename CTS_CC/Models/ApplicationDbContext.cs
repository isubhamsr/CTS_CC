using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CTS_CC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbContext")
        {

        }

        public DbSet<Member> Members { get; set; }
    }
}