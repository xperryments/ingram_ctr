using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ingram_ctr.Models;

namespace ingram_ctr.Controllers
{
    public class CounterController : Controller
    {
        //
        // GET: /Counter/

        ingram_ctrDataContext db = new ingram_ctrDataContext();

        public ActionResult Index()
        {
            var query = db.tbl_Counters.FirstOrDefault();
            var model = new CounterModel()
            {
                ctr_value = query.ctr_value
            };

            return View(model);
        }

        //
        // GET: /Counter/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Counter/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Counter/Create

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

        //
        // GET: /Counter/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Counter/Edit/5

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

        //
        // GET: /Counter/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Counter/Delete/5

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
        
        [HttpPost]
        public ActionResult UpdateCounter(int ctr)
        {
            try
            {
                tbl_Counter data = db.tbl_Counters.SingleOrDefault();
                data.ctr_value = ctr;
//                db.tbl_Counters.InsertOnSubmit(data);
                db.SubmitChanges();
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
