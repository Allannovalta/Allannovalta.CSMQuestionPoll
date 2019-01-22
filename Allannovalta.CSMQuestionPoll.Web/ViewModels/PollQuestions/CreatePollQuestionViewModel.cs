using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allannovalta.CSMQuestionPoll.Web.ViewModels.PollQuestions
{
    public class CreatePollQuestionViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string Thumbnail { get; set; }

        //[Required]
        //public string PostExpiry { get; set; }

        [Required]
        public bool Ispublished { get; set; }

        [Required]
        public DateTime PostExpiry { get; set; }

    }
}
