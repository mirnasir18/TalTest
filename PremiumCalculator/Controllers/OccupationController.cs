using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Helpers;
using PremiumCalculator.Models;
using System.Collections.Generic;

namespace PremiumCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupationController : ControllerBase
    {
        [HttpGet]
        public List<Occupation> getOccupations()
        {
            List<Occupation> occupations = new List<Occupation>()
            {
                    new Occupation()
                        {
                          id=1,
                          occupation_desc="Cleaner",
                          rating="Light Manual",
                          rating_factor=RatingFactors.LIGHT_MANUAL
                        },
                    new Occupation(){
                          id=2,
                          occupation_desc="Doctor",
                          rating="Professional",
                          rating_factor=RatingFactors.PROFESSIONAL
                        },
                   new Occupation() {
                          id=3,
                          occupation_desc="Author",
                          rating="White Collar",
                          rating_factor=RatingFactors.WHITE_COLLAR
                        },
                   new Occupation() {
                          id=4,
                          occupation_desc="Farmer",
                          rating="Heavy Manual",
                          rating_factor=RatingFactors.HEAVY_MANUAL
                        },
                   new Occupation() {
                          id=5,
                          occupation_desc="Mechanic",
                          rating="Heavy Manual",
                          rating_factor=RatingFactors.HEAVY_MANUAL
                        },
                   new Occupation() {
                      id=6,
                      occupation_desc="Florist",
                      rating="Light Manual",
                      rating_factor=RatingFactors.LIGHT_MANUAL
                    }
            };

            return occupations;
        }
    }
}

