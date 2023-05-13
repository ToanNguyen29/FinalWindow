namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MonthKeepContracts", "customerID", "dbo.Customers");
            DropForeignKey("dbo.WeekKeepContracts", "customerID", "dbo.Customers");
            DropIndex("dbo.MonthKeepContracts", new[] { "customerID" });
            DropIndex("dbo.WeekKeepContracts", new[] { "customerID" });
            CreateTable(
                "dbo.Rules",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nameContract = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LongTermKeepContracts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        key = c.String(),
                        typeVehicle = c.String(),
                        ruleID = c.Int(),
                        dateStartActual = c.DateTime(),
                        dateEnd = c.DateTime(),
                        dateStart = c.DateTime(),
                        dateEndActual = c.DateTime(),
                        fee = c.Single(),
                        penaltyFee = c.Single(),
                        customerID = c.Int(),
                        carID = c.Int(),
                        motorID = c.Int(),
                        truckID = c.Int(),
                        status = c.String(maxLength: 50),
                        option = c.String(),
                        type = c.String(),
                        period = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rules", t => t.ruleID)
                .ForeignKey("dbo.Customers", t => t.customerID)
                .ForeignKey("dbo.Cars", t => t.carID)
                .ForeignKey("dbo.Motors", t => t.motorID)
                .ForeignKey("dbo.Trucks", t => t.truckID)
                .Index(t => t.ruleID)
                .Index(t => t.customerID)
                .Index(t => t.carID)
                .Index(t => t.motorID)
                .Index(t => t.truckID);
            
            AddColumn("dbo.Customers", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.FixWorkers", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.KeepWorkers", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Managers", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Directors", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.DayKeepContracts", "typeVehicle", c => c.String());
            AddColumn("dbo.DayKeepContracts", "ruleID", c => c.Int());
            AddColumn("dbo.DayKeepContracts", "dateStartActual", c => c.DateTime());
            AddColumn("dbo.DayKeepContracts", "dateEnd", c => c.DateTime());
            AddColumn("dbo.DayKeepContracts", "dateStart", c => c.DateTime());
            AddColumn("dbo.DayKeepContracts", "dateEndActual", c => c.DateTime());
            AddColumn("dbo.DayKeepContracts", "fee", c => c.Single());
            AddColumn("dbo.DayKeepContracts", "penaltyFee", c => c.Single());
            AddColumn("dbo.DayKeepContracts", "carID", c => c.Int());
            AddColumn("dbo.DayKeepContracts", "motorID", c => c.Int());
            AddColumn("dbo.DayKeepContracts", "truckID", c => c.Int());
            AddColumn("dbo.LoanContracts", "typeVehicle", c => c.String());
            AddColumn("dbo.LoanContracts", "ruleID", c => c.Int());
            AddColumn("dbo.LoanContracts", "dateStartActual", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "dateEnd", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "dateStart", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "dateEndActual", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "fee", c => c.Single());
            AddColumn("dbo.LoanContracts", "penaltyFee", c => c.Single());
            AddColumn("dbo.LoanContracts", "carID", c => c.Int());
            AddColumn("dbo.LoanContracts", "motorID", c => c.Int());
            AddColumn("dbo.LoanContracts", "truckID", c => c.Int());
            AddColumn("dbo.LoanContracts", "condition", c => c.String());
            AddColumn("dbo.Vehicles", "licensePlates", c => c.String(maxLength: 20));
            AlterColumn("dbo.DayKeepContracts", "key", c => c.String());
            AlterColumn("dbo.LoanContracts", "key", c => c.String());
            CreateIndex("dbo.DayKeepContracts", "ruleID");
            CreateIndex("dbo.DayKeepContracts", "carID");
            CreateIndex("dbo.DayKeepContracts", "motorID");
            CreateIndex("dbo.DayKeepContracts", "truckID");
            CreateIndex("dbo.LoanContracts", "ruleID");
            CreateIndex("dbo.LoanContracts", "carID");
            CreateIndex("dbo.LoanContracts", "motorID");
            CreateIndex("dbo.LoanContracts", "truckID");
            AddForeignKey("dbo.DayKeepContracts", "ruleID", "dbo.Rules", "ID");
            AddForeignKey("dbo.DayKeepContracts", "carID", "dbo.Cars", "ID");
            AddForeignKey("dbo.DayKeepContracts", "motorID", "dbo.Motors", "ID");
            AddForeignKey("dbo.DayKeepContracts", "truckID", "dbo.Trucks", "ID");
            AddForeignKey("dbo.LoanContracts", "ruleID", "dbo.Rules", "ID");
            AddForeignKey("dbo.LoanContracts", "carID", "dbo.Cars", "ID");
            AddForeignKey("dbo.LoanContracts", "motorID", "dbo.Motors", "ID");
            AddForeignKey("dbo.LoanContracts", "truckID", "dbo.Trucks", "ID");
            DropColumn("dbo.DayKeepContracts", "contractID");
            DropColumn("dbo.DayKeepContracts", "description");
            DropColumn("dbo.DayKeepContracts", "dateCreate");
            DropColumn("dbo.DayKeepContracts", "option");
            DropColumn("dbo.LoanContracts", "contractID");
            DropColumn("dbo.LoanContracts", "description");
            DropColumn("dbo.LoanContracts", "dateCreate");
            DropColumn("dbo.LoanContracts", "dateReturn");
            DropTable("dbo.InstantKeepContracts");
            DropTable("dbo.MonthKeepContracts");
            DropTable("dbo.WeekKeepContracts");
            DropTable("dbo.Bicycles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Bicycles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        branch = c.String(),
                        picture = c.Binary(),
                        status = c.String(),
                        numberVehicle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WeekKeepContracts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        contractID = c.String(),
                        name = c.String(),
                        key = c.String(maxLength: 50),
                        description = c.String(),
                        dateCreate = c.DateTime(),
                        status = c.String(maxLength: 50),
                        option = c.String(),
                        customerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MonthKeepContracts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        contractID = c.String(),
                        name = c.String(),
                        key = c.String(maxLength: 50),
                        description = c.String(),
                        dateCreate = c.DateTime(),
                        status = c.String(maxLength: 50),
                        option = c.String(),
                        customerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InstantKeepContracts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        contractID = c.String(),
                        name = c.String(),
                        key = c.String(maxLength: 50),
                        description = c.String(),
                        dateCreate = c.DateTime(),
                        status = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.LoanContracts", "dateReturn", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "dateCreate", c => c.DateTime());
            AddColumn("dbo.LoanContracts", "description", c => c.String());
            AddColumn("dbo.LoanContracts", "contractID", c => c.String());
            AddColumn("dbo.DayKeepContracts", "option", c => c.String());
            AddColumn("dbo.DayKeepContracts", "dateCreate", c => c.DateTime());
            AddColumn("dbo.DayKeepContracts", "description", c => c.String());
            AddColumn("dbo.DayKeepContracts", "contractID", c => c.String());
            DropForeignKey("dbo.LongTermKeepContracts", "truckID", "dbo.Trucks");
            DropForeignKey("dbo.LongTermKeepContracts", "motorID", "dbo.Motors");
            DropForeignKey("dbo.LongTermKeepContracts", "carID", "dbo.Cars");
            DropForeignKey("dbo.LongTermKeepContracts", "customerID", "dbo.Customers");
            DropForeignKey("dbo.LongTermKeepContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.LoanContracts", "truckID", "dbo.Trucks");
            DropForeignKey("dbo.LoanContracts", "motorID", "dbo.Motors");
            DropForeignKey("dbo.LoanContracts", "carID", "dbo.Cars");
            DropForeignKey("dbo.LoanContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.DayKeepContracts", "truckID", "dbo.Trucks");
            DropForeignKey("dbo.DayKeepContracts", "motorID", "dbo.Motors");
            DropForeignKey("dbo.DayKeepContracts", "carID", "dbo.Cars");
            DropForeignKey("dbo.DayKeepContracts", "ruleID", "dbo.Rules");
            DropIndex("dbo.LongTermKeepContracts", new[] { "truckID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "motorID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "carID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "customerID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "ruleID" });
            DropIndex("dbo.LoanContracts", new[] { "truckID" });
            DropIndex("dbo.LoanContracts", new[] { "motorID" });
            DropIndex("dbo.LoanContracts", new[] { "carID" });
            DropIndex("dbo.LoanContracts", new[] { "ruleID" });
            DropIndex("dbo.DayKeepContracts", new[] { "truckID" });
            DropIndex("dbo.DayKeepContracts", new[] { "motorID" });
            DropIndex("dbo.DayKeepContracts", new[] { "carID" });
            DropIndex("dbo.DayKeepContracts", new[] { "ruleID" });
            AlterColumn("dbo.LoanContracts", "key", c => c.String(maxLength: 50));
            AlterColumn("dbo.DayKeepContracts", "key", c => c.String(maxLength: 50));
            DropColumn("dbo.Vehicles", "licensePlates");
            DropColumn("dbo.LoanContracts", "condition");
            DropColumn("dbo.LoanContracts", "truckID");
            DropColumn("dbo.LoanContracts", "motorID");
            DropColumn("dbo.LoanContracts", "carID");
            DropColumn("dbo.LoanContracts", "penaltyFee");
            DropColumn("dbo.LoanContracts", "fee");
            DropColumn("dbo.LoanContracts", "dateEndActual");
            DropColumn("dbo.LoanContracts", "dateStart");
            DropColumn("dbo.LoanContracts", "dateEnd");
            DropColumn("dbo.LoanContracts", "dateStartActual");
            DropColumn("dbo.LoanContracts", "ruleID");
            DropColumn("dbo.LoanContracts", "typeVehicle");
            DropColumn("dbo.DayKeepContracts", "truckID");
            DropColumn("dbo.DayKeepContracts", "motorID");
            DropColumn("dbo.DayKeepContracts", "carID");
            DropColumn("dbo.DayKeepContracts", "penaltyFee");
            DropColumn("dbo.DayKeepContracts", "fee");
            DropColumn("dbo.DayKeepContracts", "dateEndActual");
            DropColumn("dbo.DayKeepContracts", "dateStart");
            DropColumn("dbo.DayKeepContracts", "dateEnd");
            DropColumn("dbo.DayKeepContracts", "dateStartActual");
            DropColumn("dbo.DayKeepContracts", "ruleID");
            DropColumn("dbo.DayKeepContracts", "typeVehicle");
            DropColumn("dbo.Directors", "active");
            DropColumn("dbo.Users", "active");
            DropColumn("dbo.Managers", "active");
            DropColumn("dbo.KeepWorkers", "active");
            DropColumn("dbo.FixWorkers", "active");
            DropColumn("dbo.Customers", "active");
            DropTable("dbo.LongTermKeepContracts");
            DropTable("dbo.Rules");
            CreateIndex("dbo.WeekKeepContracts", "customerID");
            CreateIndex("dbo.MonthKeepContracts", "customerID");
            AddForeignKey("dbo.WeekKeepContracts", "customerID", "dbo.Customers", "ID");
            AddForeignKey("dbo.MonthKeepContracts", "customerID", "dbo.Customers", "ID");
        }
    }
}
