using LaptopStore.Data.Common;
using LaptopStore.Data.Models;
using LaptopStore.Services.Data;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.Web.Controllers
{
    public class VoteController : BaseController
    {
        IDbRepository<Vote> votes;

        private readonly IVoteService voteService;

        public VoteController(IDbRepository<Vote> votes, IVoteService voteService)
        {
            this.votes = votes;
            this.voteService = voteService;
        }

        public ActionResult Vote(int laptopId, int voteType)
        {
            if (voteType > 1)
            {
                voteType = 1;
            }
            if (voteType < -1)
            {
                voteType = -1;
            }

            var userId = this.User.Identity.GetUserId();

            var vote = this.voteService.GetAll().FirstOrDefault(x => x.AuthorId == userId && x.LaptopId == laptopId);

            if (vote == null)
            {
                vote = new Vote
                {
                    AuthorId = userId,
                    LaptopId = laptopId,
                    Type = (VoteType)voteType
                };
                this.votes.Add(vote);
            }
            else
            {
                if (vote.Type != (VoteType)voteType)
                {
                    vote.Type = VoteType.Neutral;
                }
                else if (vote.Type == VoteType.Neutral)
                {
                    vote.Type = (VoteType)voteType;
                }
            }

            this.votes.SaveChanges();
            var postVotes = this.votes.All()
                .Where(x => x.LaptopId == laptopId)
                .Sum(x => (int)x.Type);

            return this.Json(new { Count = postVotes });
        }
    }
}