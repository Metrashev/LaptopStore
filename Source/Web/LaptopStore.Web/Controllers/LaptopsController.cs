﻿namespace LaptopStore.Web.Controllers
{
    using System.Web.Mvc;

    using LaptopStore.Services.Data;
    using LaptopStore.Web.Infrastructure.Mapping;
    using LaptopStore.Web.ViewModels.Home;

    public class LaptopsController : BaseController
    {
        private readonly ILaptopsService laptops;

        public LaptopsController(
            ILaptopsService laptops)
        {
            this.laptops = laptops;
        }

        public ActionResult Index()
        {
            var laptop = this.laptops.GetAll();
            var viewModel = this.Mapper.Map<LaptopViewModel>(laptop);
            return this.View(viewModel);
        }
    }
}
