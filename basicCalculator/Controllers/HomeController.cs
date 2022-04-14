using basicCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Produces("text/html")]
        public IActionResult Calculate(string number)
        {
            CalculatorModel cal = new CalculatorModel();
            string value = new DataTable().Compute(number, null).ToString();
            cal.CalculateValue = value;
            return Content(cal.CalculateValue, "text/html", Encoding.UTF8);
        }
    }
}
