namespace LaptopStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using LaptopStore.Data.Common.Models;
    using System.Collections.Generic;

    public class Laptop : BaseModel<int>
    {
        private ICollection<Vote> votes;

        private ICollection<Cart> carts;

        public Laptop()
        {
            this.carts = new HashSet<Cart>();
            this.votes = new HashSet<Vote>();
        }

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

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }

        public virtual ICollection<Cart> Carts
        {
            get { return this.carts; }
            set { this.carts = value; }
        }
    }
}
