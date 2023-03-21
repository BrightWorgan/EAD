using EADExercise3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EADExercise3.Controllers
{
    public class TollController : Controller
    {
        // GET: TollController/Create
        public ActionResult Calculate()
        {
            ViewBag.VehicleType = new HeaderEncodingSelector(Vechicle.VehicleType);
            return;
        }
        
        // GET: TollController
        public ActionResult Index()
        {
            return View();
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
            try
            {
                return RedirectToAction(nameof(Index));
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
