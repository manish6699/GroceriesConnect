namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.Int(nullable: false),
                        PickupId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        VendorId = c.String(nullable: false, maxLength: 128),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.CartId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentOptions", t => t.PaymentId, cascadeDelete: true)
                .ForeignKey("dbo.PickupOptions", t => t.PickupId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.VendorId, cascadeDelete: true)
                .Index(t => t.CartId)
                .Index(t => t.PickupId)
                .Index(t => t.PaymentId)
                .Index(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "VendorId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "PickupId", "dbo.PickupOptions");
            DropForeignKey("dbo.Orders", "PaymentId", "dbo.PaymentOptions");
            DropForeignKey("dbo.Orders", "CartId", "dbo.Carts");
            DropIndex("dbo.Orders", new[] { "VendorId" });
            DropIndex("dbo.Orders", new[] { "PaymentId" });
            DropIndex("dbo.Orders", new[] { "PickupId" });
            DropIndex("dbo.Orders", new[] { "CartId" });
            DropTable("dbo.Orders");
        }
    }
}
