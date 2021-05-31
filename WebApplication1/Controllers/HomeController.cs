using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolContext schoolContext;

       public HomeController(ILogger<HomeController> logger, SchoolContext _schoolContext)
        {
            _logger = logger;
            schoolContext = _schoolContext;
        }
       
        public IActionResult Index()
        {

          string a =  schoolContext.Students.Where(a => a.ID == 5).Select(a => a.FirstMidName).FirstOrDefault();



            schoolContext.SaveChanges();

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
    }
}
