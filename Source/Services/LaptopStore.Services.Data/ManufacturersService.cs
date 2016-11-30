namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Common;
    using LaptopStore.Data.Models;

    public class ManufacturersService : IManufacturersService
    {
        private readonly IDbRepository<Manufacturer> manufacturers;

        public ManufacturersService(IDbRepository<Manufacturer> manufacturers)
        {
            this.manufacturers = manufacturers;
        }

        public Manufacturer EnsureCategory(string name)
        {
            var manufacturer = this.manufacturers.All().FirstOrDefault(x => x.Name == name);
            if (manufacturer != null)
            {
                return manufacturer;
            }

            manufacturer = new Manufacturer { Name = name };
            this.manufacturers.Add(manufacturer);
            this.manufacturers.SaveChanges();
            return manufacturer;
        }

        public IQueryable<Manufacturer> GetAll()
        {
            return this.manufacturers.All().OrderBy(x => x.Name);
        }
    }
}
