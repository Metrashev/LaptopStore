using LaptopStore.Data.Models;
using LaptopStore.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.Web.Areas.Administration.ViewModels
{
    public class LaptopViewModel : IMapFrom<Laptop>, IMapTo<Laptop>
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public SelectList ManufacturersList { get; set; }

        public double MonitorSize { get; set; }

        public int HardDiskSize { get; set; }

        public int RamMemorySize { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public double? Weight { get; set; }

        public string Description { get; set; }
    }
}
