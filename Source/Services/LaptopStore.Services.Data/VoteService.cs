using LaptopStore.Data.Common;
using LaptopStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.Services.Data
{
    public class VoteService : IVoteService
    {
        private readonly IDbRepository<Vote> votes;

        public VoteService(IDbRepository<Laptop> laptops)
        {
            this.votes = votes;
        }

        public IQueryable<Vote> GetAll()
        {
            return this.votes.All();
        }
    }
}
