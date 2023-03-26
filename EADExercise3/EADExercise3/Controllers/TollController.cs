using EADExercise3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EADExercise3.Controllers
{
    public class TollController : Controller
    {
        // GET: TollController/Create
        public ActionResult Calculate()
        {
            ViewBag.VehicleType = new SelectList(Vechicle.VehicleTypes);
            return View(new Vechicle { VehicleType="Car", HasETag=false});
        }

        // Post: TollController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(Vechicle vehCollection)
        {
            try
            {
                ViewBag.MyResult = vehCollection.Charge;
                return Calculate();
            }
            catch
            {
                return View();
            }
            
        }

        // GET: TollController
        public ActionResult Index()
        {
            return Calculate();
        }

        // GET: TollController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TollController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TollController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            Console.WriteLine(collection);
            try
            {
                return RedirectToAction("Calculate");
            }
            catch
            {
                return View();
            }
        }

        // GET: TollController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TollController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TollController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TollController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
