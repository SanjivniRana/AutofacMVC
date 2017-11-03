namespace w6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aman10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "week6.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
            DropTable("week6.Users");
        }
    }
}
