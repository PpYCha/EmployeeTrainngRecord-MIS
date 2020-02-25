using System.Collections.Generic;

namespace EmployeeTrainingRecord.Models
{
    public class TrainingParticipants
    {
        public int TrainingParticpantId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ExtName { get; set; }
        //public string DepartmentName { get; set; }
        //public string TrainingName { get; set; }
        public ICollection<TrainingParticipantsAttended> TrainingParticipantsAttendeds { get; internal set; }

        public int DpnId { get; set; }
        public DepartmentOfficeName DepartmentOfficeNames { get; set; }
    }
}