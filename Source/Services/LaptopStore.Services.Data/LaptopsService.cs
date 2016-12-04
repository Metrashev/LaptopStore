namespace LaptopStore.Services.Data
{
    using System;
    using System.Linq;

    using LaptopStore.Data.Common;
    using LaptopStore.Data.Models;
    using LaptopStore.Services.Web;

    public class LaptopsService : ILaptopsService
    {
        private readonly IDbRepository<Laptop> laptops;

        public LaptopsService(IDbRepository<Laptop> laptops)
        {
            this.laptops = laptops;
        }

        public IQueryable<Laptop> GetAll()
        {
            return this.laptops.All();
        }

        public Laptop Find(object id)
        {
            return this.laptops.Find(id);
        }

        public void Update(Laptop entity)
        {
            this.laptops.Update(entity);
            this.laptops.SaveChanges();
        }

        public void Add(Laptop entity)
        {
            this.laptops.Add(entity);
            this.laptops.SaveChanges();
        }

        public void Delete(object id)
        {
            this.laptops.Delete(id);
            this.laptops.SaveChanges();
        }

        public void SaveChanges()
        {
            this.laptops.SaveChanges();
        }
    }
}