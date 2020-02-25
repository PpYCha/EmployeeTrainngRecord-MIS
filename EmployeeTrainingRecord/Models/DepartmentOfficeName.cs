using System.Collections.Generic;

namespace EmployeeTrainingRecord.Models
{
    public class DepartmentOfficeName
    {
        public int DpnId { get; internal set; }
        public string DepartmentName { get; set; }

        public ICollection<TrainingParticipants> TrainingParticipants { get; internal set; }
    }
}