using Last_Irmc_Domain;
using Last_Irmc_Service.ReservationServices;
using LAST_IRMC_WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAST_IRMC_WEB.Controllers
{
    public class ReservationController : Controller
    {

        ReservationServices rs = new ReservationServices();



        // GET: Reservation
        public ActionResult Index()
        {
            



            return View();
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(ReservationViewModel Reservation)
        {
            try
            {
                // TODO: Add insert logic here


                reservation r = new reservation();
                r.reservationDate = Reservation.ReservationDate;

                if (rs.GetPlaces(r.reservationDate)>0)
                {
                    rs.Add(r);
                    rs.Commit();
                    return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservation/Edit/5
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

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservation/Delete/5
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
