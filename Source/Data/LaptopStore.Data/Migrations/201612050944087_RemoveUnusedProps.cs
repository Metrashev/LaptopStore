namespace LaptopStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnusedProps : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Carts", new[] { "IsDeleted" });
            DropColumn("dbo.Carts", "CreatedOn");
            DropColumn("dbo.Carts", "ModifiedOn");
            DropColumn("dbo.Carts", "IsDeleted");
            DropColumn("dbo.Carts", "DeletedOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Carts", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Carts", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Carts", "CreatedOn", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Carts", "IsDeleted");
        }
    }
}
