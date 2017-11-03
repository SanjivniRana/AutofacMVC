namespace w6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class r : DbMigration
    {
        public override void Up()
        {
            AddColumn("week6.Users", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("week6.Users", "Image");
        }
    }
}
