namespace LaptopStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCartId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "CartId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "CartId");
        }
    }
}
