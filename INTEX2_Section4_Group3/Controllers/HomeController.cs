using INTEX2_Section4_Group3.Data;
using INTEX2_Section4_Group3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Diagnostics;
using System.Security.Claims;

namespace INTEX2_Section4_Group3.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private LegoInfoContext _context;

        public HomeController(ILogger<HomeController> logger, LegoInfoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

      
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Confirmation()
        {
            return View();
        }

        [Authorize]
        public IActionResult Fraudulent()
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
