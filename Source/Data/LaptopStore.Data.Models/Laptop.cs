namespace LaptopStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using LaptopStore.Data.Common.Models;

    public class Laptop : BaseModel<int>
    {
        [Required]
        public string Model { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public double MonitorSize { get; set; }

        [Required]
        public int HardDiskSize { get; set; }

        [Required]
        public int RamMemorySize { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        public double? Weight { get; set; }

        public string Description { get; set; }
    }
}
