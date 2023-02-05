using System.ComponentModel.DataAnnotations;

namespace PremiumCalculator.Models
{
    public class Occupation
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Occupation is required")]
        public string occupation_desc { get; set; }
        public string rating { get; set; }
        public double rating_factor { get; set; }
    }
}
