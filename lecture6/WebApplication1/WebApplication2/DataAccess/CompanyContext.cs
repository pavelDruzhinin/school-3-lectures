using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.DataAccess
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyContext")
        {
            
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new ContactMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}