namespace LaptopStore.Services.Data
{
    using System.Linq;

    using LaptopStore.Data.Models;

    public interface IJokesService
    {
        IQueryable<Joke> GetRandomJokes(int count);

        Joke GetById(string id);
    }
}
