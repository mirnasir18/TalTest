using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Models;

namespace PremiumCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        [HttpPost]
        public double? getPremium([FromBody] Member member)
        {
            //Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12
            double? DeathPremium = (member.death_sum_insured * member.occupation?.rating_factor * member.age) / 1000 * 12;
            return DeathPremium;
        }
    }
}
