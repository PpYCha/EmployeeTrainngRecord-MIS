namespace EmployeeTrainingRecord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aUpadte : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainingParticipantsAttendeds",
                c => new
                    {
                        TpaId = c.Int(nullable: false, identity: true),
                        TrainingParticpantId = c.Int(nullable: false),
                        TrainingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TpaId)
                .ForeignKey("dbo.TrainingInfoes", t => t.TrainingId, cascadeDelete: true)
                .ForeignKey("dbo.TrainingParticipants", t => t.TrainingParticpantId, cascadeDelete: true)
                .Index(t => t.TrainingParticpantId)
                .Index(t => t.TrainingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingParticipantsAttendeds", "TrainingParticpantId", "dbo.TrainingParticipants");
            DropForeignKey("dbo.TrainingParticipantsAttendeds", "TrainingId", "dbo.TrainingInfoes");
            DropIndex("dbo.TrainingParticipantsAttendeds", new[] { "TrainingId" });
            DropIndex("dbo.TrainingParticipantsAttendeds", new[] { "TrainingParticpantId" });
            DropTable("dbo.TrainingParticipantsAttendeds");
        }
    }
}
