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
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult listVideo2()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/IRMC-web/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("irmc/videos").Result;
            if (response.IsSuccessStatusCode)
            {


               
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<mon_video>>().Result;
                

            }
            else
            {
                ViewBag.result = "error";
            }
            return View();
        }

        // GET: Video/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Video/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Video/Create
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

        // GET: Video/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Video/Edit/5
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

        // GET: Video/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Video/Delete/5
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
