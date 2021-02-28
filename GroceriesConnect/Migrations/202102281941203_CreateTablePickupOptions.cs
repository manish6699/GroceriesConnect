namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePickupOptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PickupOptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OptionName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PickupOptions");
        }
    }
}
