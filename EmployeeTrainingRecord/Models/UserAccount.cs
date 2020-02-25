namespace EmployeeTrainingRecord.Models
{
    public class UserAccount
    {
        public int UserId { get; internal set; }

        public string Username { get; set; }
        public string UserPassword { get; set; }

    }
}