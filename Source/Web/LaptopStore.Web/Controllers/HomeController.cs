namespace LaptopStore.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using Services.Data;

    using ViewModels.Home;

    public class HomeController : BaseController
    {
        //private readonly ILaptopsService laptops;
        //private readonly IManufacturersService manufacturers;

        //public HomeController(
        //    ILaptopsService laptops,
        //    IManufacturersService manufacturers)
        //{
        //    this.laptops = laptops;
        //    this.manufacturers = manufacturers;
        //}

        public ActionResult Index()
        {
            //var laptops = this.laptops.GetAll().To<LaptopViewModel>().ToList();
            //var manufacturers =
            //    this.Cache.Get(
            //        "manufacturers",
            //        () => this.manufacturers.GetAll().To<ManufacturerViewModel>().ToList(),
            //        30 * 60);
            //var viewModel = new IndexViewModel
            //{
            //    Laptops = laptops,
            //    Manufacturers = manufacturers
            //};

            return View();
        }
    }
}
