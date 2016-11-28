namespace LaptopStore.Web.ViewModels.Home
{
    using LaptopStore.Data.Models;
    using LaptopStore.Web.Infrastructure.Mapping;

    public class JokeCategoryViewModel : IMapFrom<JokeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
