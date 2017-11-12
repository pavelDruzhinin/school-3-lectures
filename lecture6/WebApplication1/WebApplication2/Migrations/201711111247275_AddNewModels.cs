namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyContacts",
                c => new
                    {
                        Company_Id = c.Int(nullable: false),
                        Contact_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Company_Id, t.Contact_Id })
                .ForeignKey("dbo.Companies", t => t.Company_Id, cascadeDelete: true)
                .ForeignKey("dbo.Contacts", t => t.Contact_Id, cascadeDelete: true)
                .Index(t => t.Company_Id)
                .Index(t => t.Contact_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyContacts", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.CompanyContacts", "Company_Id", "dbo.Companies");
            DropIndex("dbo.CompanyContacts", new[] { "Contact_Id" });
            DropIndex("dbo.CompanyContacts", new[] { "Company_Id" });
            DropTable("dbo.CompanyContacts");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
        }
    }
}
