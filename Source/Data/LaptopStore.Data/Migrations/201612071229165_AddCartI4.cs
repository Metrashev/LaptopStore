namespace LaptopStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCartI4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.Carts", new[] { "AuthorId" });
            DropColumn("dbo.Carts", "AuthorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "AuthorId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Carts", "AuthorId");
            AddForeignKey("dbo.Carts", "AuthorId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
