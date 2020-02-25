namespace EmployeeTrainingRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTraining : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartmentOfficeNames", "DepartmentName", c => c.String());
            AddColumn("dbo.TrainingInfoes", "TrainingName", c => c.String());
            AddColumn("dbo.TrainingInfoes", "DateConducted", c => c.DateTime());
            AddColumn("dbo.TrainingParticipants", "FirstName", c => c.String());
            AddColumn("dbo.TrainingParticipants", "MiddleName", c => c.String());
            AddColumn("dbo.TrainingParticipants", "LastName", c => c.String());
            AddColumn("dbo.TrainingParticipants", "ExtName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrainingParticipants", "ExtName");
            DropColumn("dbo.TrainingParticipants", "LastName");
            DropColumn("dbo.TrainingParticipants", "MiddleName");
            DropColumn("dbo.TrainingParticipants", "FirstName");
            DropColumn("dbo.TrainingInfoes", "DateConducted");
            DropColumn("dbo.TrainingInfoes", "TrainingName");
            DropColumn("dbo.DepartmentOfficeNames", "DepartmentName");
        }
    }
}
