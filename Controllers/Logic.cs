using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace check.Controllers
{
    public class Logic : Controller
    {
        // GET: Logic
        public ActionResult Index()
        {
            return View();
        }

        // GET: Logic/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Logic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logic/Create
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

        // GET: Logic/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Logic/Edit/5
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

        // GET: Logic/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Logic/Delete/5
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
