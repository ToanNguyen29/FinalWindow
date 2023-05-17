namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntt1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DayKeepContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.LoanContracts", "ruleID", "dbo.Rules");
            DropForeignKey("dbo.LongTermKeepContracts", "ruleID", "dbo.Rules");
            DropIndex("dbo.DayKeepContracts", new[] { "ruleID" });
            DropIndex("dbo.LoanContracts", new[] { "ruleID" });
            DropIndex("dbo.LongTermKeepContracts", new[] { "ruleID" });
            AddColumn("dbo.DayKeepContracts", "rule", c => c.String());
            AddColumn("dbo.LoanContracts", "rule", c => c.String());
            AddColumn("dbo.LongTermKeepContracts", "rule", c => c.String());
            AddColumn("dbo.LongTermKeepContracts", "is_Loan", c => c.Boolean(nullable: false));
            DropColumn("dbo.DayKeepContracts", "ruleID");
            DropColumn("dbo.LoanContracts", "ruleID");
            DropColumn("dbo.LongTermKeepContracts", "ruleID");
            DropColumn("dbo.LongTermKeepContracts", "option");
            DropColumn("dbo.LongTermKeepContracts", "type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LongTermKeepContracts", "type", c => c.String());
            AddColumn("dbo.LongTermKeepContracts", "option", c => c.String());
            AddColumn("dbo.LongTermKeepContracts", "ruleID", c => c.Int());
            AddColumn("dbo.LoanContracts", "ruleID", c => c.Int());
            AddColumn("dbo.DayKeepContracts", "ruleID", c => c.Int());
            DropColumn("dbo.LongTermKeepContracts", "is_Loan");
            DropColumn("dbo.LongTermKeepContracts", "rule");
            DropColumn("dbo.LoanContracts", "rule");
            DropColumn("dbo.DayKeepContracts", "rule");
            CreateIndex("dbo.LongTermKeepContracts", "ruleID");
            CreateIndex("dbo.LoanContracts", "ruleID");
            CreateIndex("dbo.DayKeepContracts", "ruleID");
            AddForeignKey("dbo.LongTermKeepContracts", "ruleID", "dbo.Rules", "ID");
            AddForeignKey("dbo.LoanContracts", "ruleID", "dbo.Rules", "ID");
            AddForeignKey("dbo.DayKeepContracts", "ruleID", "dbo.Rules", "ID");
        }
    }
}
