namespace CompanyWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Street = c.String(),
                        StreetNumber = c.String(),
                        Postcode = c.String(),
                        City = c.String(),
                        Nip = c.String(),
                        Krs = c.String(),
                        Regon = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Company");
        }
    }
}
