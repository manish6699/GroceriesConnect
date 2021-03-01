namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableItemsAddColumnStocksAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "StocksAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "StocksAvailable");
        }
    }
}
