namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(maxLength: 128),
                        VendorId = c.String(maxLength: 128),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId)
                .ForeignKey("dbo.AspNetUsers", t => t.VendorId)
                .Index(t => t.CustomerId)
                .Index(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "VendorId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Carts", "CustomerId", "dbo.AspNetUsers");
            DropIndex("dbo.Carts", new[] { "VendorId" });
            DropIndex("dbo.Carts", new[] { "CustomerId" });
            DropTable("dbo.Carts");
        }
    }
}
