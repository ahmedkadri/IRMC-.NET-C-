using Last_Irmc_Service.OffreService;
using LAST_IRMC_WEB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAST_IRMC_WEB.Controllers
{
    public class ChartController : Controller
    {
        IOffreServices os = new OffreServices();



        // GET: Chart
        public ActionResult Index()
        {
            List<Chart> dataPoints = new List<Chart>();
            dataPoints.Add(new Chart("les offre de stage", 10));
            dataPoints.Add(new Chart("les offre de bourse", 30));
            dataPoints.Add(new Chart("les offre d emploi", 60));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            return View();
        }

        // GET: Chart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chart/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Chart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
