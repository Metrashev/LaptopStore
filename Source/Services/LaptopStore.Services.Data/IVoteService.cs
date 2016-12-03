using LaptopStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.Services.Data
{
    public interface IVoteService
    {
        IQueryable<Vote> GetAll();
    }
}
