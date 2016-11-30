
namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Models;

    public interface ILaptopsService
    {
        IQueryable<Laptop> GetAll();

        Laptop Find(object id);

        void Update(Laptop entity);

        void Add(Laptop entity);

        void Delete(object id);

        void SaveChanges();
    }
}