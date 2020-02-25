using System.Data.Entity;

namespace EmployeeTrainingRecord.Models
{
    internal class EtrDbInitializer : CreateDatabaseIfNotExists<EtrContext>
    {
    }
}