namespace LaptopStore.Web.ViewModels.Home
{
    using AutoMapper;
    using LaptopStore.Data.Models;
    using LaptopStore.Services.Web;
    using LaptopStore.Web.Infrastructure.Mapping;
    using System.Collections.Generic;
    using System.Linq;

    public class LaptopViewModel : IMapFrom<Laptop>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public ManufacturerViewModel Manufacturer { get; set; }

        public double MonitorSize { get; set; }

        public int HardDiskSize { get; set; }

        public int RamMemorySize { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public double? Weight { get; set; }

        public string Description { get; set; }

        public int VotesCount { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Laptop, LaptopViewModel>()
                .ForMember(x => x.VotesCount,
                opt => opt.MapFrom(x => x.Votes.Any() ? x.Votes.Sum(v => (int)v.Type) : 0));
        }
    }
}
