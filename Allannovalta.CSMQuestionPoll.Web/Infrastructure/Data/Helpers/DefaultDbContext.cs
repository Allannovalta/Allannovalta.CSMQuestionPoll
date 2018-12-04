using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
   : base(options)
        {
        }
        #region Models
        public DbSet<User> Users { get; set; }
        #endregion

        #region PollQuestion
        public DbSet<PollQuestion> PollQuestions { get; set; }
        #endregion

        #region PollChoice
        public DbSet<PollChoice> PollChoice { get; set; }
        #endregion

        #region PollAnswer
        public DbSet<PollAnswer> PollAnswer { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
