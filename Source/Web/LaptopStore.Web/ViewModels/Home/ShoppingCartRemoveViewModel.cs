﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopStore.Web.ViewModels.Home
{
    public class ShoppingCartRemoveViewModel
    {
        public decimal CartTotal { get; set; }

        public int CartCount { get; set; }

        public int ItemCount { get; set; }

        public int DeleteId { get; set; }
    }
}