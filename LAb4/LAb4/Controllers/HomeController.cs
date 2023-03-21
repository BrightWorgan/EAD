using LAb4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LAb4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private class AnimeQuote
        {
            public string? anime { get; set; }
            public string? character { get; set; }
            public string? quote { get; set; }
        }

        public async Task<IActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetFromJsonAsync<AnimeQuote>("https://animechan.vercel.app/api/random");
                ViewBag.AnimeQuote = res.quote;
                ViewBag.AnimeCharacter = res.character;
                ViewBag.Anime = res.anime;
            }
            return View();
        }

        public IActionResult ShowTime()
        {
            ViewBag.DateAndTime = "The Current Date and Time is : " + DateTime.Now + " \nand your current time zone is: "+ TimeZone.CurrentTimeZone.StandardName;
            return View("ShowTime");
        }


        [HttpGet]
        public int DoThing()
        {
            return 55;
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