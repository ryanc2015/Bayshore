using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bayshore.CodeTest.Models;

namespace Bayshore.CodeTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel()
            {
                Number = 0,
                TestComplete = false
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult CheckForPalindrom(IndexViewModel vm)
        {
            if(ModelState.IsValid)
            {
                vm.IsPalindrome = IsPalindrome(vm.Number.Value);
                vm.TestComplete = true;
                return View("Index", vm);
            }

            return View("Index", vm);
        }

        public bool IsPalindrome(int number)
        {
            IEnumerable<char> forwards = number.ToString().ToCharArray();
            return forwards.SequenceEqual(forwards.Reverse());            
        }
    }
}
