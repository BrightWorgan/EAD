using EADExercise1AzureCloudService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace EADExercise1AzureCloudService.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController/Create
        public ActionResult CalculateServiceCost()
        {
            ViewBag.InstanceSize = new SelectList(Instance.InstanceTypes);
            return View(new Instance() { NumOfInstances = 2 });
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalculateServiceCost(Instance svc)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm", svc);
            }
            else
            {
                ViewBag.InstanceSize = new SelectList(Instance.InstanceTypes);
                return View(new Instance() { NumOfInstances = 2 });
            }
        }

        public ActionResult Confirm(Instance svc)
        {
            return View(svc);
        }





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
    }
}