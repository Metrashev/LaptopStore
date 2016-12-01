namespace LaptopStore.Web.Controllers
{
    using System.Web.Mvc;

    using LaptopStore.Services.Data;
    using LaptopStore.Web.Infrastructure.Mapping;
    using LaptopStore.Web.ViewModels.Home;
    using Services.Web;
    using System.Collections.Generic;
    using Data.Models;
    using System.Linq;

    public class LaptopsController : BaseController
    {
        private readonly ILaptopsService laptopsService;

        private readonly ICacheService cacheService;

        public LaptopsController(
            ILaptopsService laptopsService,
            ICacheService cacheService)
        {
            this.laptopsService = laptopsService;
            this.cacheService = cacheService;
        }

        //public ActionResult Index()
        //{
        //    //var dbLaptops = this.cacheService.Get<ICollection<Laptop>>("allLaptops", () =>
        //    //{
        //    //    return laptopsService.GetAll();
        //    //}, 60);
        //    var dbLaptops = laptopsService.GetAll().ToList();
        //    var laptops = Mapper.Map<ICollection<Laptop>,
        //        ICollection<LaptopViewModel>>(dbLaptops);

        //    //var laptop = this.laptops.GetAll();
        //    //var viewModel = this.Mapper.Map<LaptopViewModel>(laptop);
        //    return this.View(laptops);
        //}
    }
}
