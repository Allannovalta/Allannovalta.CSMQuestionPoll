using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models
{
    public class PollAnswer : BaseModel
    {
        public Guid? PollQuestionId { get; set; }
        public Guid? PollChoiceId { get; set; }
    }
}
