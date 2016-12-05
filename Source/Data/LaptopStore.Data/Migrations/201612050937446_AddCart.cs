namespace LaptopStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorId = c.String(nullable: false, maxLength: 128),
                        LaptopId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Laptops", t => t.LaptopId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.LaptopId)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "LaptopId", "dbo.Laptops");
            DropForeignKey("dbo.Carts", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.Carts", new[] { "IsDeleted" });
            DropIndex("dbo.Carts", new[] { "LaptopId" });
            DropIndex("dbo.Carts", new[] { "AuthorId" });
            DropTable("dbo.Carts");
        }
    }
}
