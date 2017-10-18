namespace CompanyWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Company", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Company", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Company", "StreetNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Company", "Postcode", c => c.String(nullable: false));
            AlterColumn("dbo.Company", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Company", "Nip", c => c.String(nullable: false));
            AlterColumn("dbo.Company", "Krs", c => c.String(nullable: false));
            AlterColumn("dbo.Company", "Regon", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Company", "Regon", c => c.String());
            AlterColumn("dbo.Company", "Krs", c => c.String());
            AlterColumn("dbo.Company", "Nip", c => c.String());
            AlterColumn("dbo.Company", "City", c => c.String());
            AlterColumn("dbo.Company", "Postcode", c => c.String());
            AlterColumn("dbo.Company", "StreetNumber", c => c.String());
            AlterColumn("dbo.Company", "Street", c => c.String());
            AlterColumn("dbo.Company", "Name", c => c.String());
        }
    }
}
