namespace LaptopStore.Data.Models
{
    using LaptopStore.Data.Common.Models;

    public class Laptop : BaseModel<int>
    {
        public string Content { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
