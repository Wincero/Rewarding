using Microsoft.AspNetCore.Mvc;
using RewardingBackend.Data;
using RewardingBackend.Models;

namespace RewardingBackend.Controllers
{
    [ApiController]
    [Route("api/rewards")]
    public class RewardsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public RewardsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost("reward")]
        public async Task<ActionResult> CreateReward([FromBody] CreateRewardtDto rewardDto)
        {
            var reward = new Reward
            {
                EmployeeId = rewardDto.EmployeeId,
                RewardText = rewardDto.RewardText,
                Date = DateTime.UtcNow,
                Status = "New"
            };

            try
            {
                _context.Rewards.Add(reward);
                await _context.SaveChangesAsync();
                return StatusCode(201, reward);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

    public class CreateRewardtDto
    {
        public Guid EmployeeId { get; set; }
        public string RewardText { get; set; }
    }
}