namespace LaptopStore.Data.Models
{
    using System.Collections.Generic;

    using LaptopStore.Data.Common.Models;

    public class Manufacturer : BaseModel<int>
    {
        public Manufacturer()
        {
            this.Laptops = new HashSet<Laptop>();
        }

        public string Name { get; set; }

        public virtual ICollection<Laptop> Laptops { get; set; }
    }
}
