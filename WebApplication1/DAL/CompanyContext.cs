using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CompanyWebAPI.Models;

namespace CompanyWebAPI.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyContext")
        {
            
        }
        static CompanyContext()
        {
            Database.SetInitializer(new CompanyInitializer());
        }

        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}