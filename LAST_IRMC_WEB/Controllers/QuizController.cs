using Last_Irmc_Domain;
using Last_Irmc_Service.QuizServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAST_IRMC_WEB.Controllers
{
    public class QuizController : Controller
    {
        quiz q = new quiz();
        IQuizServices qzs = new QuizServices();
        IQuestionServices qss = new QuestionServices();
        // GET: Quiz
        public ActionResult listquiz()
        {
            ViewBag.result = qzs.GetAll();
            return View();
        }

        // GET: Quiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        public ActionResult Create(quiz quu)
        {
            try
            {
                if (qzs.ifexiste(quu.quiz_nom)== true)
                {
                    TempData["message"] = "quiz existe deja";
                    return RedirectToAction("Confirmation");
                }
                else
                {
                    qzs.Add(quu);
                    qzs.Commit();
                    q = quu;
                    return RedirectToAction("Create2");

                }
              
                // TODO: Add insert logic here


               
            }
            catch
            {
                return View();
            }
        }



        public ActionResult Confirmation()
        {
            string message = TempData["message"] as string;
            ViewBag.message = message;
            return View();
        }
        public ActionResult Create2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create2(question que)
        {
            try
            {

             //   q = qzs.getbyname(q.quiz_nom);
              //  que.quiz3_quiz_id = q.quiz_id;
                qss.Add(que);
                qss.Commit();
                // TODO: Add insert logic here


                return RedirectToAction("listquiz");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Edit/5
        public ActionResult Edit(int id)
        {
            quiz q = qzs.GetById(id);
            return View(q);
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here


               quiz q = qzs.GetById(id);

                q.quiz_nom = collection["quiz_nom"];
                qzs.Update(q);
                qzs.Commit();

                return RedirectToAction("listquiz");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Delete/5
        public ActionResult Delete(int id)
        {

            
            return View();
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,quiz q)
        {
            try
            {

                q = qzs.GetById(id);
                // TODO: Add delete logic here
                qzs.Delete(q);
                qzs.Commit();
                return RedirectToAction("listquiz");
            }
            catch
            {
                return View();
            }
        }
    }
}
