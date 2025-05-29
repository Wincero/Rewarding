using System.ComponentModel.DataAnnotations.Schema;

namespace RewardingBackend.Models
{
    public class Reward
    {
        public int RewardId { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        public string RewardText { get; set; }

        public string Status { get; set; }
    }
}