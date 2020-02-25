namespace EmployeeTrainingRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentOfficeNames",
                c => new
                    {
                        DpnId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DpnId);
            
            CreateTable(
                "dbo.TrainingInfoes",
                c => new
                    {
                        TrainingId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TrainingId);
            
            CreateTable(
                "dbo.TrainingParticipants",
                c => new
                    {
                        TrainingParticpantId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TrainingParticpantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrainingParticipants");
            DropTable("dbo.TrainingInfoes");
            DropTable("dbo.DepartmentOfficeNames");
        }
    }
}
