using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppParsons.Models
{
    public class BirthdayCalc
    {
        private const int CURRENT_YEAR = 2020;

        [Required(ErrorMessage = "Please enter the year you were born in")]
        [Range(0, CURRENT_YEAR, ErrorMessage = "Must be born between 0 AD and now.")]
        public int? BirthYear { get; set; }
        
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }
        public decimal AgeThisYear()
        {
            int age;

            age = CURRENT_YEAR - BirthYear.Value;

            return age;
        }
    }
}
