namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Common;
    using LaptopStore.Data.Models;

    public class ManufacturersService : IManufacturersService
    {
        private readonly IDbRepository<Manufacturer> categories;

        public ManufacturersService(IDbRepository<Manufacturer> categories)
        {
            this.categories = categories;
        }

        public Manufacturer EnsureCategory(string name)
        {
            var category = this.categories.All().FirstOrDefault(x => x.Name == name);
            if (category != null)
            {
                return category;
            }

            category = new Manufacturer { Name = name };
            this.categories.Add(category);
            this.categories.Save();
            return category;
        }

        public IQueryable<Manufacturer> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }
    }
}
