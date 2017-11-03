namespace AutofacDatatable.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aman : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "week6.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Name = c.String(nullable: false, maxLength: 100),
                        TeamId = c.Int(),
                        RoleId = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        IsPersonMarried = c.Boolean(nullable: false),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("week6.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("week6.Team", t => t.TeamId)
                .Index(t => t.TeamId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "week6.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Email = c.String(),
                        Phone = c.String(),
                        IsPersonMarried = c.Boolean(nullable: false),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "week6.Team",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Email = c.String(),
                        Phone = c.String(),
                        IsPersonMarried = c.Boolean(nullable: false),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "week6.Log",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Action = c.String(),
                        Name = c.String(nullable: false, maxLength: 250),
                        Email = c.String(),
                        Phone = c.String(),
                        IsPersonMarried = c.Boolean(nullable: false),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("week6.User", "TeamId", "week6.Team");
            DropForeignKey("week6.User", "RoleId", "week6.Role");
            DropIndex("week6.User", new[] { "RoleId" });
            DropIndex("week6.User", new[] { "TeamId" });
            DropTable("week6.Log");
            DropTable("week6.Team");
            DropTable("week6.Role");
            DropTable("week6.User");
        }
    }
}
