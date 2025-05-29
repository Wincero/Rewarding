using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardingFrontend.Models
{
    internal class Employee
    {
        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronimic { get; set; }

        public string Position { get; set; }

        public string Role { get; set; }

        public Guid? ManagerId { get; set; }
    }
}
