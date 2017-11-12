using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace WebApplication2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Company> Companies { get; set; }
    }

    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            ToTable("Contacts");
            HasKey(x => x.Id);
            HasMany(x => x.Companies);
        }
    }
}