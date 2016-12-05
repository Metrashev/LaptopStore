using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.Web.Controllers
{
    public class CartController : BaseController
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult CartCount()
        {
            //var cart = ShoppingCart.GetCart(this.HttpContext);

            //ViewData["CartCount"] = cart.GetCount();

            return PartialView("CartCount");
        }
    }
}