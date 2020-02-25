namespace EmployeeTrainingRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingParticipants", "DepartmentName", c => c.String());
            AddColumn("dbo.TrainingParticipants", "TrainingName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrainingParticipants", "TrainingName");
            DropColumn("dbo.TrainingParticipants", "DepartmentName");
        }
    }
}
