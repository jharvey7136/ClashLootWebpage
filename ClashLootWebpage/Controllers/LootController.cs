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
        // GET: Loot
        public ActionResult Index()
        {
            LootDBHandle dbhandle = new LootDBHandle();
            return View();
        }

        // GET: Loot/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Loot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loot/Create
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

        // GET: Loot/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Loot/Edit/5
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

        // GET: Loot/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

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
    }
}
