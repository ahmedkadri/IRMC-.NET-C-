using Last_Irmc_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace LAST_IRMC_WEB.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/irmc-web/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("pi/libraries").Result;
            if (response.IsSuccessStatusCode)
            {


                // installer .net formating
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<library>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View();

        }

        // GET: Library/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Library/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Library/Create
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

        // GET: Library/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Library/Edit/5
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

        // GET: Library/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Library/Delete/5
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
