namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCatalogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catalogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CategoryId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Catalogs", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Catalogs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Catalogs", new[] { "UserId" });
            DropIndex("dbo.Catalogs", new[] { "CategoryId" });
            DropTable("dbo.Catalogs");
        }
    }
}
