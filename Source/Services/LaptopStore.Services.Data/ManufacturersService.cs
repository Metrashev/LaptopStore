namespace LaptopStore.Services.Data
{
    using System;
    using System.Linq;

    using LaptopStore.Data.Common;
    using LaptopStore.Data.Models;

    public class ManufacturersService : IManufacturersService
    {
        private readonly IDbRepository<Manufacturer> manufacturer;

        public ManufacturersService(IDbRepository<Manufacturer> manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public void Add(Manufacturer entity)
        {
            this.manufacturer.Add(entity);
            this.manufacturer.SaveChanges();
        }

        public void Delete(object id)
        {
            this.manufacturer.Delete(id);
            this.manufacturer.SaveChanges();
        }

        public Manufacturer Find(object id)
        {
            return this.manufacturer.Find(id);
        }

        public IQueryable<Manufacturer> GetAll()
        {
            return this.manufacturer.All();
        }

        public void SaveChanges()
        {
            this.manufacturer.SaveChanges();
        }

        public void Update(Manufacturer entity)
        {
            this.manufacturer.Update(entity);
            this.manufacturer.SaveChanges();
        }
    }
}
