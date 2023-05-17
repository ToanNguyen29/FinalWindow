namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntt2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LongTermKeepContracts", "typeContract", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LongTermKeepContracts", "typeContract");
        }
    }
}
