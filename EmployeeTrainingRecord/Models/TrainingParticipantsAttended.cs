using System.Collections.Generic;

namespace EmployeeTrainingRecord.Models
{
    public class TrainingParticipantsAttended
    {
        public int TpaId { get; set; }


        public int TrainingParticpantId { get; set; }
        public TrainingParticipants TrainingParticipants { get; set; }

        public int TrainingId { get; set; }
        public TrainingInfo TrainingInfo { get; set; }

    }
}
