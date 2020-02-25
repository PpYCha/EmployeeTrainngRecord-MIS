using System;
using System.Collections.Generic;

namespace EmployeeTrainingRecord.Models
{
    public class TrainingInfo
    {
        public int TrainingId { get;  set; }
        public string TrainingName { get; set; }
        public DateTime? DateConducted { get; set; }

        public ICollection<TrainingParticipantsAttended> TrainingParticipantsAttendeds { get; internal set; }
    }
}