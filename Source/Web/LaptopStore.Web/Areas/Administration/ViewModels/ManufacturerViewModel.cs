using LaptopStore.Data.Models;
using LaptopStore.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaptopStore.Web.Areas.Administration.ViewModels
{
    public class ManufacturerViewModel : IMapFrom<Manufacturer>, IMapTo<Manufacturer>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}