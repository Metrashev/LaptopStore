namespace LaptopStore.Web.ViewModels.Home
{
    using AutoMapper;
    using LaptopStore.Data.Models;
    using LaptopStore.Services.Web;
    using LaptopStore.Web.Infrastructure.Mapping;

    public class LaptopViewModel : IMapFrom<Laptop>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Manufacturer { get; set; }

        public string Url
        {
            get
            {
                IIdentifierProvider identifier = new IdentifierProvider();
                return $"/Laptop/{identifier.EncodeId(this.Id)}";
            }
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Laptop, LaptopViewModel>()
                .ForMember(x => x.Manufacturer, opt => opt.MapFrom(x => x.Manufacturer.Name));
        }
    }
}
