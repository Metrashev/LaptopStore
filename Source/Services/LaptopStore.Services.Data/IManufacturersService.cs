namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Models;

    public interface IManufacturersService
    {
        IQueryable<Manufacturer> GetAll();

        Manufacturer Find(object id);

        void Update(Manufacturer entity);

        void Add(Manufacturer entity);

        void Delete(object id);

        void SaveChanges();
    }
}
