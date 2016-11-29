namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Models;

    public interface IManufacturersService
    {
        IQueryable<Manufacturer> GetAll();

        Manufacturer EnsureCategory(string name);
    }
}
