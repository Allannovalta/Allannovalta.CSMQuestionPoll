using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.ViewModels.PollQuestions
{
    public class PollQuestionViewModel
    {
        public Page<PollQuestion> PollQuestions { get; set; }
    }
}
