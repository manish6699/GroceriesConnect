namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CatalogId = c.Int(nullable: false),
                        ItemName = c.String(nullable: false, maxLength: 128),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Catalogs", t => t.CatalogId, cascadeDelete: true)
                .Index(t => t.CatalogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "CatalogId", "dbo.Catalogs");
            DropIndex("dbo.Items", new[] { "CatalogId" });
            DropTable("dbo.Items");
        }
    }
}
