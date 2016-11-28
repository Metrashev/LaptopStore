namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Models;

    public interface ICategoriesService
    {
        IQueryable<JokeCategory> GetAll();

        JokeCategory EnsureCategory(string name);
    }
}
