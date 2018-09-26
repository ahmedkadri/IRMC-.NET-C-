using Last_Irmc_Domain;
using Last_Irmc_Service.QuizServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LAST_IRMC_WEB.Controllers
{
    public class OffreController : Controller
    {

        IQuizServices qzs = new QuizServices();

        // GET: Offre
        public ActionResult listoffre()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080/IRMC-web/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("irmc/offre/all").Result;
            if (response.IsSuccessStatusCode)
            {


                // installer .net formating
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<offre>>().Result;
                // ViewBag.result = response.Content.ReadAsAsync<IEnumerable<quiz>>().Result;
                
            }
            else
            {
                ViewBag.result = "error";
            }
            return View();
        }

        // GET: Offre/Postuler/5
        
        public ActionResult Postuler(int id)
        {
            ListReponss listq = new ListReponss();

            ViewBag.result = qzs.getthequestion(id);
            var x = qzs.getthequestion(id).ToList();
            ViewData["question"] = x;

            

            return View();
        }

        [HttpPost]
        public ActionResult Postuler(List<string> lista)
        {
            
           
            StringBuilder sb = new StringBuilder();

            //string x2 = chkBox1.Value;

            //foreach (var item in lista)
            //{

            //        sb.Append(item+" ,");

            //}
            ViewBag.selectrep = lista;
           // ViewData["listaa"] = lista;

            return View();
        }

        public ActionResult repp()
        {
           string listaa = ViewData["listaa"] as string;
            ViewBag.lista = listaa;

            return View();
        }

        // GET: Offre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Offre/Create
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

        // GET: Offre/Edit/5
       

        // POST: Offre/Edit/5
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

        // GET: Offre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Offre/Delete/5
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
        // POST: Offre/Repondre
    
        
         
    }
}
