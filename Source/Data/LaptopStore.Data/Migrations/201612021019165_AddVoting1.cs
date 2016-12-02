namespace LaptopStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVoting1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VotedById = c.String(maxLength: 128),
                        LaptopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Laptops", t => t.LaptopId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.VotedById)
                .Index(t => t.VotedById)
                .Index(t => t.LaptopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "VotedById", "dbo.AspNetUsers");
            DropForeignKey("dbo.Votes", "LaptopId", "dbo.Laptops");
            DropIndex("dbo.Votes", new[] { "LaptopId" });
            DropIndex("dbo.Votes", new[] { "VotedById" });
            DropTable("dbo.Votes");
        }
    }
}
