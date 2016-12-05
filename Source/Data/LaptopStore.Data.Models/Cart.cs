﻿using LaptopStore.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.Data.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public int LaptopId { get; set; }

        public virtual Laptop Laptop { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
