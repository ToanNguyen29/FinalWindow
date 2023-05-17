namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntt4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeeKeeps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        typeVehicle = c.String(),
                        dayPrice = c.Single(),
                        weekPrice = c.Single(),
                        monthPrice = c.Single(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.DayKeepContracts", "typeVehicle");
            DropColumn("dbo.LoanContracts", "typeVehicle");
            DropColumn("dbo.LongTermKeepContracts", "typeVehicle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LongTermKeepContracts", "typeVehicle", c => c.String());
            AddColumn("dbo.LoanContracts", "typeVehicle", c => c.String());
            AddColumn("dbo.DayKeepContracts", "typeVehicle", c => c.String());
            DropTable("dbo.FeeKeeps");
        }
    }
}
