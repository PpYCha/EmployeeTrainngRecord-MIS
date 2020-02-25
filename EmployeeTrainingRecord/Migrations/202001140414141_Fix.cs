namespace EmployeeTrainingRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingParticipants", "DpnId", c => c.Int(nullable: false));
            CreateIndex("dbo.TrainingParticipants", "DpnId");
            AddForeignKey("dbo.TrainingParticipants", "DpnId", "dbo.DepartmentOfficeNames", "DpnId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingParticipants", "DpnId", "dbo.DepartmentOfficeNames");
            DropIndex("dbo.TrainingParticipants", new[] { "DpnId" });
            DropColumn("dbo.TrainingParticipants", "DpnId");
        }
    }
}
