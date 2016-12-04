using LaptopStore.Data.Common;
using LaptopStore.Data.Models;
using LaptopStore.Services.Data;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.Web.Controllers
{
    public class VoteController : BaseController
    {
        public class LaptopVoting
        {
            public int LaptopId { get; set; }

            public int VoteType { get; set; }
        }

        private IVoteService voteService;

        public VoteController(IVoteService voteService)
        {
            this.voteService = voteService;
        }

        [HttpPost]
        public ActionResult Voting(LaptopVoting laptopModel)
        {
            if (laptopModel.VoteType > 1)
            {
                laptopModel.VoteType = 1;
            }
            if (laptopModel.VoteType < -1)
            {
                laptopModel.VoteType = -1;
            }

            var userId = this.User.Identity.GetUserId();

            var votes = this.voteService;
            
            var vote = votes
                .GetAll().FirstOrDefault(x => x.LaptopId == laptopModel.LaptopId);

            if (vote == null)
            {
                vote = new Vote
                {
                    AuthorId = userId,
                    LaptopId = laptopModel.LaptopId,
                    Type = (VoteType)laptopModel.VoteType
                };
                this.voteService.Add(vote);
            }
            else
            {
                if (vote.Type != (VoteType)laptopModel.VoteType)
                {
                    vote.Type = VoteType.Neutral;
                }
                else if (vote.Type == VoteType.Neutral)
                {
                    vote.Type = (VoteType)laptopModel.VoteType;
                }
            }

            this.voteService.SaveChanges();
            var postVotes = this.voteService.GetAll()
                .Where(x => x.LaptopId == laptopModel.LaptopId)
                .Sum(x => (int)x.Type);

            return this.Json(new { Count = postVotes });
        }
    }
}