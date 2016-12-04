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
        private IDbRepository<Vote> votes;

        public VoteService(IDbRepository<Vote> votes)
        {
            this.votes = votes;
        }

        public IQueryable<Vote> GetAll()
        {
            return this.votes.All();
        }

        public void Add(Vote entity)
        {
            this.votes.Add(entity);
            this.votes.SaveChanges();
        }

        public void SaveChanges()
        {
            this.votes.SaveChanges();
        }
    }
}
