namespace LaptopStore.Data.Models
{
    using System.Collections.Generic;

    using LaptopStore.Data.Common.Models;
    using System.ComponentModel.DataAnnotations;

    public class Manufacturer : BaseModel<int>
    {
        public Manufacturer()
        {
            this.Laptops = new HashSet<Laptop>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Laptop> Laptops { get; set; }
    }
}
