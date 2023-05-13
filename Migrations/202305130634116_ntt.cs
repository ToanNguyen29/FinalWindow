namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BillFixes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        status = c.String(maxLength: 50),
                        dateCreate = c.DateTime(),
                        fixWorkerID = c.Int(),
                        customerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.customerID)
                .ForeignKey("dbo.FixWorkers", t => t.fixWorkerID)
                .Index(t => t.fixWorkerID)
                .Index(t => t.customerID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        phone = c.String(maxLength: 20),
                        email = c.String(),
                        birthday = c.DateTime(),
                        dateCreate = c.DateTime(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        branch = c.String(),
                        picture = c.Binary(),
                        status = c.String(),
                        numberVehicle = c.String(),
                        licensePlates = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
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
                "dbo.Facilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        address = c.String(maxLength: 50),
                        quatityFix = c.Int(),
                        quantityKeep = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        quantityKeep = c.Int(),
                        quantityFix = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BillFixAccessories",
                c => new
                    {
                        BillFix_ID = c.Int(nullable: false),
                        Accessory_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BillFix_ID, t.Accessory_ID })
                .ForeignKey("dbo.BillFixes", t => t.BillFix_ID, cascadeDelete: true)
                .ForeignKey("dbo.Accessories", t => t.Accessory_ID, cascadeDelete: true)
                .Index(t => t.BillFix_ID)
                .Index(t => t.Accessory_ID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        phone = c.String(maxLength: 20),
                        email = c.String(),
                        birthday = c.DateTime(),
                        dateCreate = c.DateTime(),
                        active = c.Boolean(nullable: false),
                        cardID = c.String(),
                        address = c.String(maxLength: 50),
                        picture = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        phone = c.String(maxLength: 20),
                        email = c.String(),
                        birthday = c.DateTime(),
                        dateCreate = c.DateTime(),
                        active = c.Boolean(nullable: false),
                        cardID = c.String(),
                        address = c.String(),
                        picture = c.Binary(),
                        facilityID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Facilities", t => t.facilityID)
                .Index(t => t.facilityID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        phone = c.String(maxLength: 20),
                        email = c.String(),
                        birthday = c.DateTime(),
                        dateCreate = c.DateTime(),
                        active = c.Boolean(nullable: false),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FixWorkers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        phone = c.String(maxLength: 20),
                        email = c.String(),
                        birthday = c.DateTime(),
                        dateCreate = c.DateTime(),
                        active = c.Boolean(nullable: false),
                        cardID = c.String(),
                        address = c.String(),
                        picture = c.Binary(),
                        shiftID = c.Int(),
                        facilityID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Shifts", t => t.shiftID)
                .ForeignKey("dbo.Facilities", t => t.facilityID)
                .Index(t => t.shiftID)
                .Index(t => t.facilityID);
            
            CreateTable(
                "dbo.KeepWorkers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        phone = c.String(maxLength: 20),
                        email = c.String(),
                        birthday = c.DateTime(),
                        dateCreate = c.DateTime(),
                        active = c.Boolean(nullable: false),
                        cardID = c.String(),
                        address = c.String(),
                        picture = c.Binary(),
                        shiftID = c.Int(),
                        facilityID = c.Int(),
                        facilityKeep = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Shifts", t => t.shiftID)
                .ForeignKey("dbo.Facilities", t => t.facilityID)
                .Index(t => t.shiftID)
                .Index(t => t.facilityID);
            
            CreateTable(
                "dbo.DayKeepContracts",
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
            
            CreateTable(
                "dbo.LoanContracts",
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
                        condition = c.String(),
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
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        branch = c.String(),
                        picture = c.Binary(),
                        status = c.String(),
                        numberVehicle = c.String(),
                        licensePlates = c.String(maxLength: 20),
                        seat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Motors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        branch = c.String(),
                        picture = c.Binary(),
                        status = c.String(),
                        numberVehicle = c.String(),
                        licensePlates = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Trucks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        branch = c.String(),
                        picture = c.Binary(),
                        status = c.String(),
                        numberVehicle = c.String(),
                        licensePlates = c.String(maxLength: 20),
                        tonnage = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LongTermKeepContracts", "truckID", "dbo.Trucks");
            DropForeignKey("dbo.LongTermKeepContracts", "motorID", "dbo.Motors");
            DropForeignKey("dbo.LongTermKeepContracts", "carID", "dbo.Cars");
            DropForeignKey("dbo.LongTermKeepContracts", "customerID", "dbo.Customers");
            DropForeignKey("dbo.LongTermKeepContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.LoanContracts", "truckID", "dbo.Trucks");
            DropForeignKey("dbo.LoanContracts", "motorID", "dbo.Motors");
            DropForeignKey("dbo.LoanContracts", "carID", "dbo.Cars");
            DropForeignKey("dbo.LoanContracts", "customerID", "dbo.Customers");
            DropForeignKey("dbo.LoanContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.DayKeepContracts", "truckID", "dbo.Trucks");
            DropForeignKey("dbo.DayKeepContracts", "motorID", "dbo.Motors");
            DropForeignKey("dbo.DayKeepContracts", "carID", "dbo.Cars");
            DropForeignKey("dbo.DayKeepContracts", "customerID", "dbo.Customers");
            DropForeignKey("dbo.DayKeepContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.KeepWorkers", "facilityID", "dbo.Facilities");
            DropForeignKey("dbo.KeepWorkers", "shiftID", "dbo.Shifts");
            DropForeignKey("dbo.FixWorkers", "facilityID", "dbo.Facilities");
            DropForeignKey("dbo.FixWorkers", "shiftID", "dbo.Shifts");
            DropForeignKey("dbo.Managers", "facilityID", "dbo.Facilities");
            DropForeignKey("dbo.BillFixes", "fixWorkerID", "dbo.FixWorkers");
            DropForeignKey("dbo.BillFixes", "customerID", "dbo.Customers");
            DropForeignKey("dbo.BillFixAccessories", "Accessory_ID", "dbo.Accessories");
            DropForeignKey("dbo.BillFixAccessories", "BillFix_ID", "dbo.BillFixes");
            DropIndex("dbo.LongTermKeepContracts", new[] { "truckID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "motorID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "carID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "customerID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "ruleID" });
            DropIndex("dbo.LoanContracts", new[] { "truckID" });
            DropIndex("dbo.LoanContracts", new[] { "motorID" });
            DropIndex("dbo.LoanContracts", new[] { "carID" });
            DropIndex("dbo.LoanContracts", new[] { "customerID" });
            DropIndex("dbo.LoanContracts", new[] { "ruleID" });
            DropIndex("dbo.DayKeepContracts", new[] { "truckID" });
            DropIndex("dbo.DayKeepContracts", new[] { "motorID" });
            DropIndex("dbo.DayKeepContracts", new[] { "carID" });
            DropIndex("dbo.DayKeepContracts", new[] { "customerID" });
            DropIndex("dbo.DayKeepContracts", new[] { "ruleID" });
            DropIndex("dbo.KeepWorkers", new[] { "facilityID" });
            DropIndex("dbo.KeepWorkers", new[] { "shiftID" });
            DropIndex("dbo.FixWorkers", new[] { "facilityID" });
            DropIndex("dbo.FixWorkers", new[] { "shiftID" });
            DropIndex("dbo.Managers", new[] { "facilityID" });
            DropIndex("dbo.BillFixAccessories", new[] { "Accessory_ID" });
            DropIndex("dbo.BillFixAccessories", new[] { "BillFix_ID" });
            DropIndex("dbo.BillFixes", new[] { "customerID" });
            DropIndex("dbo.BillFixes", new[] { "fixWorkerID" });
            DropTable("dbo.Trucks");
            DropTable("dbo.Motors");
            DropTable("dbo.Cars");
            DropTable("dbo.LongTermKeepContracts");
            DropTable("dbo.LoanContracts");
            DropTable("dbo.DayKeepContracts");
            DropTable("dbo.KeepWorkers");
            DropTable("dbo.FixWorkers");
            DropTable("dbo.Customers");
            DropTable("dbo.Managers");
            DropTable("dbo.Directors");
            DropTable("dbo.BillFixAccessories");
            DropTable("dbo.Shifts");
            DropTable("dbo.Facilities");
            DropTable("dbo.Rules");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Users");
            DropTable("dbo.BillFixes");
            DropTable("dbo.Accessories");
        }
    }
}
