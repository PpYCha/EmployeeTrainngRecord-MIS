namespace EmployeeTrainingRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixPArit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TrainingParticipants", "DepartmentName");
            DropColumn("dbo.TrainingParticipants", "TrainingName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrainingParticipants", "TrainingName", c => c.String());
            AddColumn("dbo.TrainingParticipants", "DepartmentName", c => c.String());
        }
    }
}
