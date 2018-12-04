using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models
{
    public class PollQuestion : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PostExpiry { get; set; }
        
    }
}
