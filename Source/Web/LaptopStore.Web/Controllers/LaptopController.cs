namespace LaptopStore.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using Services.Data;
    using PagedList;
    using ViewModels.Home;
    using System.Collections.Generic;
    using Data.Models;
    using System;
    using Microsoft.AspNet.Identity;

    public class LaptopController : BaseController
    {
        private readonly ILaptopsService laptopsService;
        private readonly IManufacturersService manufacturersService;

        public LaptopController(
            ILaptopsService laptopsService,
            IManufacturersService manufacturersService)
        {
            this.laptopsService = laptopsService;
            this.manufacturersService = manufacturersService;
        }

        public ActionResult Index(int? page)
        {
            var dblaptops =
                this.Cache.Get(
                    "LaptopsCaching",
                    () => this.laptopsService
                    .GetAll().ToList(),
                    60).ToList();

            var laptops = Mapper.Map<ICollection<Laptop>,
                ICollection<LaptopViewModel>>(dblaptops);

            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return this.View(laptops.ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            var laptop = Mapper.Map<LaptopViewModel>(this.laptopsService.Find(id));
            return View(laptop);
        }
    }
}
