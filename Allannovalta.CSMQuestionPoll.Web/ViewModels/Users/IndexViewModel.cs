//using Allannovalta.CSMQuestionPoll.Web.Areas.Infrastructure.Data.Models;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
