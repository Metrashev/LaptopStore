﻿namespace LaptopStore.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<LaptopViewModel> Laptops { get; set; }

        public IEnumerable<ManufacturerViewModel> Manufacturers { get; set; }
    }
}