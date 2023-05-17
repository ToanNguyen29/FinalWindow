namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntt5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DayKeepContracts", "facilityId", c => c.Int());
            AddColumn("dbo.LoanContracts", "facilityId", c => c.Int());
            AddColumn("dbo.LongTermKeepContracts", "facilityId", c => c.Int());
            CreateIndex("dbo.DayKeepContracts", "facilityId");
            CreateIndex("dbo.LoanContracts", "facilityId");
            CreateIndex("dbo.LongTermKeepContracts", "facilityId");
            AddForeignKey("dbo.DayKeepContracts", "facilityId", "dbo.Facilities", "ID");
            AddForeignKey("dbo.LoanContracts", "facilityId", "dbo.Facilities", "ID");
            AddForeignKey("dbo.LongTermKeepContracts", "facilityId", "dbo.Facilities", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LongTermKeepContracts", "facilityId", "dbo.Facilities");
            DropForeignKey("dbo.LoanContracts", "facilityId", "dbo.Facilities");
            DropForeignKey("dbo.DayKeepContracts", "facilityId", "dbo.Facilities");
            DropIndex("dbo.LongTermKeepContracts", new[] { "facilityId" });
            DropIndex("dbo.LoanContracts", new[] { "facilityId" });
            DropIndex("dbo.DayKeepContracts", new[] { "facilityId" });
            DropColumn("dbo.LongTermKeepContracts", "facilityId");
            DropColumn("dbo.LoanContracts", "facilityId");
            DropColumn("dbo.DayKeepContracts", "facilityId");
        }
    }
}
