namespace FinalWindow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nts5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shifts", "startTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Shifts", "endTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shifts", "endTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Shifts", "startTime", c => c.DateTime(nullable: false));
        }
    }
}
