using System.ComponentModel.DataAnnotations;

namespace PremiumCalculator.Models
{
    public class Member
    {
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        public int age { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public string date_of_birth { get; set; }
        [Required(ErrorMessage = "Death Sum insured is required")]
        public int death_sum_insured { get; set; }
        public Occupation occupation { get; set; }
    }
}



