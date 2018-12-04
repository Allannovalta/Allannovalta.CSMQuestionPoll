using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.ViewModels.PollQuestions
{
    public class PollQuestion
    {
        public Page<PollQuestion> PollQuestions { get; set; }
    }
}
