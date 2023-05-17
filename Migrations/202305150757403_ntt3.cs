namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntt3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DayKeepContracts", "dateCreate", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "dateCreate", c => c.DateTime());
            AddColumn("dbo.LongTermKeepContracts", "dateCreate", c => c.DateTime());
            DropColumn("dbo.DayKeepContracts", "dateStart");
            DropColumn("dbo.LoanContracts", "dateStart");
            DropColumn("dbo.LongTermKeepContracts", "dateStart");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LongTermKeepContracts", "dateStart", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "dateStart", c => c.DateTime());
            AddColumn("dbo.DayKeepContracts", "dateStart", c => c.DateTime());
            DropColumn("dbo.LongTermKeepContracts", "dateCreate");
            DropColumn("dbo.LoanContracts", "dateCreate");
            DropColumn("dbo.DayKeepContracts", "dateCreate");
        }
    }
}
