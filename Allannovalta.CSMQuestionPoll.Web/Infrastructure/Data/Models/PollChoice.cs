using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models
{
    public class PollChoice : BaseModel
    {
        public Guid? PollQuestionId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
