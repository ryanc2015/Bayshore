using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bayshore.CodeTest.Models
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Number is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid positive number")]
        public int? Number { get; set; }
        public bool IsPalindrome { get; set; }
        public bool TestComplete { get; set; }
    }
}
