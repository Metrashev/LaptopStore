using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LaptopStore.Data;
using LaptopStore.Data.Models;
using LaptopStore.Web.Controllers;
using LaptopStore.Web.Areas.Administration.ViewModels;
using LaptopStore.Services.Data;
using AutoMapper;

namespace LaptopStore.Web.Areas.Administration.Controllers
{
    public class ManufacturersController : BaseController
    {
        private IManufacturersService manufacturersService;

        private ILaptopsService laptopsService;

        public ManufacturersController(
            ILaptopsService laptopService,
            IManufacturersService manufacturersService)
        {
            this.laptopsService = laptopService;
            this.manufacturersService = manufacturersService;
        }

        //private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Administration/Manufacturers
        public ActionResult Index()
        {
            return View(manufacturersService.GetAll().ToList());
        }

        // GET: Administration/Manufacturers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturer manufacturer = this.manufacturersService.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        // GET: Administration/Manufacturers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Manufacturers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManufacturerViewModel manufacturer)
        {
            if (ModelState.IsValid)
            {
                var dbmanufacturer = Mapper.Map<Manufacturer>(manufacturer);
                this.manufacturersService.Add(dbmanufacturer);
                return RedirectToAction("Index");
            }

            return View(manufacturer);
        }

        // GET: Administration/Manufacturers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturer manufacturer = this.manufacturersService.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        // POST: Administration/Manufacturers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ManufacturerViewModel manufacturer)
        {
            if (ModelState.IsValid)
            {
                var dbManufacturer = Mapper.Map<Manufacturer>(manufacturer);
                dbManufacturer.CreatedOn = DateTime.Now;
                this.manufacturersService.Update(dbManufacturer);
                return RedirectToAction("Index");
            }
            return View(manufacturer);
        }

        // GET: Administration/Manufacturers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturer manufacturer = this.manufacturersService.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        // POST: Administration/Manufacturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Manufacturer manufacturer = this.manufacturersService.Find(id);
            this.manufacturersService.Delete(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
