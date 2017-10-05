namespace CompanyWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApiLogEntry",
                c => new
                    {
                        ApiLogEntryId = c.Long(nullable: false, identity: true),
                        Application = c.String(),
                        User = c.String(),
                        Machine = c.String(),
                        RequestIpAddress = c.String(),
                        RequestContentType = c.String(),
                        RequestContentBody = c.String(),
                        RequestUri = c.String(),
                        RequestMethod = c.String(),
                        RequestRouteTemplate = c.String(),
                        RequestRouteData = c.String(),
                        RequestHeaders = c.String(),
                        RequestTimestamp = c.DateTime(),
                        ResponseContentType = c.String(),
                        ResponseContentBody = c.String(),
                        ResponseStatusCode = c.Int(),
                        ResponseHeaders = c.String(),
                        ResponseTimestamp = c.DateTime(),
                    })
                .PrimaryKey(t => t.ApiLogEntryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApiLogEntry");
        }
    }
}
