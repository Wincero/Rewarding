using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardingFrontend.Models
{
    internal class Reward
    {
        public int RewardId { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public Guid EmployeeId { get; set; }

        public string RewardText { get; set; }

        public string Status { get; set; }
    }

    public class CreateRewardtDto
    {
        public Guid EmployeeId { get; set; }
        public string RewardText { get; set; }
    }
}
