namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Models;

    public interface ILaptopsService
    {
        IQueryable<Laptop> GetRandomLaptops(int count);

        Laptop GetById(string id);
    }
}
