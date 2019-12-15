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

            CreateTable(
                "dbo.Salaries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SponsorId = c.Int(nullable: false),
                    AllCash = c.Single(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sponsors", t => t.SponsorId, cascadeDelete: true)
                .Index(t => t.SponsorId);

            CreateTable(
                "dbo.Sponsors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Cash = c.Single(nullable: false),
                    JumperId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jumpers", t => t.JumperId, cascadeDelete: true)
                .Index(t => t.JumperId);

            CreateTable(
                "dbo.Trainers",
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
            DropForeignKey("dbo.Trainers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Salaries", "SponsorId", "dbo.Sponsors");
            DropForeignKey("dbo.Sponsors", "JumperId", "dbo.Jumpers");
            DropForeignKey("dbo.Jumpers", "CountryId", "dbo.Countries");
            DropIndex("dbo.Trainers", new[] { "CountryId" });
            DropIndex("dbo.Sponsors", new[] { "JumperId" });
            DropIndex("dbo.Salaries", new[] { "SponsorId" });
            DropIndex("dbo.Jumpers", new[] { "CountryId" });
            DropTable("dbo.Trainers");
            DropTable("dbo.Sponsors");
            DropTable("dbo.Salaries");
            DropTable("dbo.Jumpers");
            DropTable("dbo.Countries");
        }
    }
}
