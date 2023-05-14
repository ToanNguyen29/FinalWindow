namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "picture");
        }
    }
}
