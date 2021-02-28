namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnVendorIdFromTableCart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "VendorId", "dbo.AspNetUsers");
            DropIndex("dbo.Carts", new[] { "VendorId" });
            DropColumn("dbo.Carts", "VendorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "VendorId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Carts", "VendorId");
            AddForeignKey("dbo.Carts", "VendorId", "dbo.AspNetUsers", "Id");
        }
    }
}
