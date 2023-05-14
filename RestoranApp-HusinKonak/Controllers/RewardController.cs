using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoranApp_HusinKonak.Classes_for_Restaurant;
using RestoranApp_HusinKonak.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoranApp_HusinKonak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly RestaurantDBContext _context;

        public RewardsController(RestaurantDBContext context)
        {
            _context = context;
        }

        // GET: api/rewards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reward>>> GetRewards()
        {
            return await _context.Rewards.ToListAsync();
        }

        // GET: api/rewards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reward>> GetReward(int id)
        {
            var reward = await _context.Rewards.FindAsync(id);

            if (reward == null)
            {
                return NotFound();
            }

            return reward;
        }

        // POST: api/rewards
        [HttpPost]
        public async Task<ActionResult<Reward>> PostReward(RewardInputModel rewardInputModel)
        {
            var reward = new Reward
            {
                EmployeeID = rewardInputModel.EmployeeID,
                Description = rewardInputModel.Description,
                Date = rewardInputModel.Date,
                Amount = rewardInputModel.Amount
            };

            _context.Rewards.Add(reward);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReward), new { id = reward.RewardId }, reward);
        }
    }

    public class RewardInputModel
    {
        public int EmployeeID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}