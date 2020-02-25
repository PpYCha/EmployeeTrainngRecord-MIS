using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace EmployeeTrainingRecord.Models
{
    public class EtrContext : DbContext
    {
        public EtrContext()
            : base("EtrContext")
        {
            Database.SetInitializer<EtrContext>(new EtrDbInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EtrContext, Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<DepartmentOfficeName> DepartmentOfficeNames { get; set; }
        public DbSet<TrainingParticipants> TrainingParticipants { get; set; }
        public DbSet<TrainingInfo> TrainingInfo { get; set; }
        public DbSet<TrainingParticipantsAttended> TrainingParticipantsAttendeds { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().HasKey(k => k.UserId)
              .Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<DepartmentOfficeName>().HasKey(k => k.DpnId)
            .Property(p => p.DpnId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TrainingParticipants>().HasKey(k => k.TrainingParticpantId)
                .Property(p => p.TrainingParticpantId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TrainingInfo>().HasKey(k => k.TrainingId)
                .Property(p => p.TrainingId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TrainingParticipantsAttended>().HasKey(k => k.TpaId)
                .Property(p => p.TpaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TrainingParticipants>()
                .HasRequired<DepartmentOfficeName>(k => k.DepartmentOfficeNames)
                .WithMany(p => p.TrainingParticipants)
                .HasForeignKey<int>(k => k.DpnId);

            modelBuilder.Entity<TrainingParticipantsAttended>()
              .HasRequired<TrainingParticipants>(k => k.TrainingParticipants)
              .WithMany(p => p.TrainingParticipantsAttendeds)
              .HasForeignKey<int>(k => k.TrainingParticpantId);

            modelBuilder.Entity<TrainingParticipantsAttended>()
             .HasRequired<TrainingInfo>(k => k.TrainingInfo)
             .WithMany(p => p.TrainingParticipantsAttendeds)
             .HasForeignKey<int>(k => k.TrainingId);
        }
    }

}
