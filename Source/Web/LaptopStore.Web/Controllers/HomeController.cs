namespace LaptopStore.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using Services.Data;

    using ViewModels.Home;
    using System.Collections.Generic;
    using Data.Models;

    public class HomeController : BaseController
    {
        private readonly ILaptopsService laptopsService;
        private readonly IManufacturersService manufacturersService;

        public HomeController(
            ILaptopsService laptopsService,
            IManufacturersService manufacturers)
        {
            this.laptopsService = laptopsService;
            this.manufacturersService = manufacturersService;
        }

        [Authorize]
        public ActionResult Index()
        {
            var dbLaptops = laptopsService.GetAll().ToList();
            var laptops = Mapper.Map<ICollection<Laptop>,
                ICollection<LaptopViewModel>>(dbLaptops);

            return this.View(laptops);
        }
    }
}
