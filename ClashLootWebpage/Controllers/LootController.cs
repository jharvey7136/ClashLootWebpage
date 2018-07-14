using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClashLootWebpage.Models;

namespace ClashLootWebpage.Controllers
{
    public class LootController : Controller
    {
        // *****************Retrieve all loot records*****************
        // GET: Loot
        public ActionResult Index()
        {
            LootDBHandle dbhandle = new LootDBHandle();
            ModelState.Clear();
            return View();
        }


        // GET: Loot/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // *****************Add a new loot record manually*****************
        // GET: Loot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loot/Create
        [HttpPost]
        public ActionResult Create(LootModel smodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LootDBHandle ldb = new LootDBHandle();
                    if (ldb.AddRecord(smodel))
                    {
                        ViewBag.Message = "Loot Record Added Successfully";
                        ModelState.Clear();
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // *****************Edit loot record details manually*****************
        // GET: Loot/Edit/5
        public ActionResult Edit(int id)
        {
            LootDBHandle ldb = new LootDBHandle();
            return View(ldb.GetRecords().Find(smodel => smodel.Id == id));
        }

        // POST: Loot/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LootModel smodel)
        {
            try
            {
                LootDBHandle ldb = new LootDBHandle();
                ldb.UpdateRecord(smodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //*****************Delete loot record manually*****************
        // GET: Loot/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                LootDBHandle ldb = new LootDBHandle();
                if (ldb.DeleteRecord(id))
                {
                    ViewBag.AlertMsg = "Loot Record Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        /*
        // POST: Loot/Delete/5
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
        */
    }
}
