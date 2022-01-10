using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMvc1.Models;

namespace WebMvc1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
        [HttpPost]
        public IActionResult Form1(FormModel model)
        {
            DateTime thisDay = DateTime.Today;

            string userBirhday = model.Description;
            DateTime Date = Convert.ToDateTime(userBirhday);

            DateTime birthDays = Date;

            if(Date.Date > thisDay.Date)
            {
                ViewBag.Result = "Błąd: ";
                string numberOfDays = "Twoja data urodzin nie może przekraczać bieżącego roku!";
                ViewBag.DaysNumber = numberOfDays;
            }
            else
            {
                ViewBag.Result = "Dni które upłyneły od twoich urodzin: ";
                int numberOfDays = (thisDay - birthDays).Days;
                ViewBag.DaysNumber = numberOfDays;
            }
            
            return View(model);
        }      

    }
}
