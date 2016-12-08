using LaptopStore.Data.Models;
using LaptopStore.Services.Data;
using LaptopStore.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopStore.Web.ViewModels.Home
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }

        public decimal CartTotal { get; set; }
    }
}