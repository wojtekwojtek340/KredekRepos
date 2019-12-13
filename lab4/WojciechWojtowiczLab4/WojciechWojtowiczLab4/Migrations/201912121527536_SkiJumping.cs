namespace WojciechWojtowiczLab4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkiJumping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryRecord = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jumpers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        Birtdate = c.DateTime(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jumpers", "CountryId", "dbo.Countries");
            DropIndex("dbo.Jumpers", new[] { "CountryId" });
            DropTable("dbo.Jumpers");
            DropTable("dbo.Countries");
        }
    }
}
