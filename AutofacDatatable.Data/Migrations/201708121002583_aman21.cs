namespace AutofacDatatable.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aman21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("week6.User", "TeamId", "week6.Team");
            DropForeignKey("week6.User", "RoleId", "week6.Role");
            DropIndex("week6.User", new[] { "TeamId" });
            DropIndex("week6.User", new[] { "RoleId" });
            RenameColumn(table: "week6.User", name: "RoleId", newName: "Role_Id");
            AlterColumn("week6.User", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("week6.User", "Role_Id", c => c.Int());
            CreateIndex("week6.User", "Role_Id");
            AddForeignKey("week6.User", "Role_Id", "week6.Role", "Id");
            DropColumn("week6.User", "Password");
        }
        
        public override void Down()
        {
            AddColumn("week6.User", "Password", c => c.String());
            DropForeignKey("week6.User", "Role_Id", "week6.Role");
            DropIndex("week6.User", new[] { "Role_Id" });
            AlterColumn("week6.User", "Role_Id", c => c.Int(nullable: false));
            AlterColumn("week6.User", "Name", c => c.String(nullable: false, maxLength: 100));
            RenameColumn(table: "week6.User", name: "Role_Id", newName: "RoleId");
            CreateIndex("week6.User", "RoleId");
            CreateIndex("week6.User", "TeamId");
            AddForeignKey("week6.User", "RoleId", "week6.Role", "Id", cascadeDelete: true);
            AddForeignKey("week6.User", "TeamId", "week6.Team", "Id");
        }
    }
}
