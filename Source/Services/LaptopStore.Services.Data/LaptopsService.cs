namespace LaptopStore.Services.Data
{
    using System;
    using System.Linq;

    using LaptopStore.Data.Common;
    using LaptopStore.Data.Models;
    using LaptopStore.Services.Web;

    public class LaptopsService : ILaptopsService
    {
        private readonly IDbRepository<Laptop> laptops;
        private readonly IIdentifierProvider identifierProvider;

        public LaptopsService(IDbRepository<Laptop> laptops, IIdentifierProvider identifierProvider)
        {
            this.laptops = laptops;
            this.identifierProvider = identifierProvider;
        }

        public Laptop GetById(string id)
        {
            var intId = this.identifierProvider.DecodeId(id);
            var laptop = this.laptops.GetById(intId);
            return laptop;
        }

        public IQueryable<Laptop> GetRandomLaptops(int count)
        {
            return this.laptops.All().OrderBy(x => Guid.NewGuid()).Take(count);
        }
    }
}
