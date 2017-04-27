namespace TripProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJourney : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Journeys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransportationType = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        EndPoint_Id = c.Int(),
                        StartPoint_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LocationPoints", t => t.EndPoint_Id)
                .ForeignKey("dbo.LocationPoints", t => t.StartPoint_Id)
                .Index(t => t.EndPoint_Id)
                .Index(t => t.StartPoint_Id);
            
            CreateTable(
                "dbo.LocationPoints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journeys", "StartPoint_Id", "dbo.LocationPoints");
            DropForeignKey("dbo.Journeys", "EndPoint_Id", "dbo.LocationPoints");
            DropIndex("dbo.Journeys", new[] { "StartPoint_Id" });
            DropIndex("dbo.Journeys", new[] { "EndPoint_Id" });
            DropTable("dbo.LocationPoints");
            DropTable("dbo.Journeys");
        }
    }
}
