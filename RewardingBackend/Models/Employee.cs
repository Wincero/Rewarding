using System.ComponentModel.DataAnnotations.Schema;

namespace RewardingBackend.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronimic { get; set; }

        public string Position { get; set; }

        public string Role { get; set; }

        [ForeignKey("Employee")]
        public Guid? ManagerId { get; set; }
    }
}