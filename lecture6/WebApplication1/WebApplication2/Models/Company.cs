using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace WebApplication2.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Contact> Contacts { get; set; }
    }

    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            ToTable("Companies");
            HasKey(x => x.Id);
            HasMany(x => x.Contacts);
        }
    }
}