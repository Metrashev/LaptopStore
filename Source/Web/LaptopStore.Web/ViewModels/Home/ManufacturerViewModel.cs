namespace LaptopStore.Web.ViewModels.Home
{
    using LaptopStore.Data.Models;
    using LaptopStore.Web.Infrastructure.Mapping;

    public class ManufacturerViewModel : IMapFrom<Manufacturer>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
