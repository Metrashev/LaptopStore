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

namespace LaptopStore.Web.Areas.Administration.Controllers
{
    public class LaptopsController : BaseController
    {

        private ILaptopsService laptopsService;

        private IManufacturersService manufacturersService;

        public LaptopsController(
            ILaptopsService laptopService,
            IManufacturersService manufacturersService)
        {
            this.laptopsService = laptopService;
            this.manufacturersService = manufacturersService;
        }

        // GET: Administration/Laptops
        public ActionResult Index()
        {
            var laptops = Mapper.Map<List<Laptop>, List<LaptopViewModel>>(laptopsService.GetAll().ToList());
            return View(laptops);
        }

        // GET: Administration/Laptops/Create
        public ActionResult Create()
        {
            ViewBag.ManufacturerId = new SelectList(this.manufacturersService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Administration/Laptops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(LaptopViewModel laptop)
        {
            if (ModelState.IsValid)
            {
                var dbLaptop = Mapper.Map<Laptop>(laptop);
                this.laptopsService.Add(dbLaptop);
                return RedirectToAction("Index");
            }

            ViewBag.ManufacturersList = new SelectList(this.manufacturersService.GetAll(), "Id", "Name", laptop.ManufacturersList);
            return View(laptop);
        }

        // GET: Administration/Laptops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laptop laptop = this.laptopsService.Find(id);
            if (laptop == null)
            {
                return HttpNotFound();
            }
            return this.View(laptop);
        }

        // GET: Administration/Laptops/Edit/5
        [ValidateInput(false)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laptop laptop = laptopsService.Find(id);
            if (laptop == null)
            {
                return HttpNotFound();
            }

            LaptopViewModel laptopViewModel = Mapper.Map<LaptopViewModel>(laptop);
            laptopViewModel.ManufacturersList = new SelectList(manufacturersService.GetAll(), "Id", "Name");
            return this.View(laptopViewModel);
        }

        // POST: Administration/Laptops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LaptopViewModel laptop)
        {
            if (ModelState.IsValid)
            {
                var dbLaptop = Mapper.Map<Laptop>(laptop);
                dbLaptop.CreatedOn = DateTime.Now;
                this.laptopsService.Update(dbLaptop);
                return RedirectToAction("Index");
            }
            //ViewBag.ManufacturersList = new SelectList(this.manufacturersService.GetAll(), "Id", "Name", laptop.ManufacturersList);
            laptop.ManufacturersList = new SelectList(this.manufacturersService.GetAll(), "Id", "Name", laptop.ManufacturerId);
            return View(laptop);
        }

        // GET: Administration/Laptops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laptop laptop = this.laptopsService.Find(id);
            if (laptop == null)
            {
                return HttpNotFound();
            }
            return this.View(laptop);
        }

        // POST: Administration/Laptops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            this.laptopsService.Delete(id);
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
