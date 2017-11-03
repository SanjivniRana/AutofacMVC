namespace w6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class r2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "week6.Cts",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "week6.Stas",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        Abbr = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
            AddColumn("week6.Users", "Sta", c => c.Int(nullable: false));
            AddColumn("week6.Users", "Ct", c => c.Int(nullable: false));
            DropColumn("week6.Users", "State");
            DropColumn("week6.Users", "City");
        }
        
        public override void Down()
        {
            AddColumn("week6.Users", "City", c => c.String());
            AddColumn("week6.Users", "State", c => c.String());
            DropColumn("week6.Users", "Ct");
            DropColumn("week6.Users", "Sta");
            DropTable("week6.Stas");
            DropTable("week6.Cts");
        }
    }
}
