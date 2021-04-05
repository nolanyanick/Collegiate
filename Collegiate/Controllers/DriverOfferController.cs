using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Collegiate.Controllers
{
    public class DriverOfferController : Controller
    {
        // GET: DriverOffer
        public ActionResult Index()
        {
            return View();
        }

        // GET: DriverOffer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DriverOffer/Create
        public ActionResult CreateToNMC()
        {
            return View();
        }

        // POST: DriverOffer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateToNMC(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DriverOffer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DriverOffer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DriverOffer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DriverOffer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}