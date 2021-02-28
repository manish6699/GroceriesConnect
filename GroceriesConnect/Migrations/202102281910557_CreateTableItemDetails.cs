namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableItemDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        CartId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.CartId, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.CartId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemDetails", "ItemId", "dbo.Items");
            DropForeignKey("dbo.ItemDetails", "CartId", "dbo.Carts");
            DropIndex("dbo.ItemDetails", new[] { "CartId" });
            DropIndex("dbo.ItemDetails", new[] { "ItemId" });
            DropTable("dbo.ItemDetails");
        }
    }
}
