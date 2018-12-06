using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Allannovalta.CSMQuestionPoll.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PollQuestionsController : Controller
    {

        private readonly DefaultDbContext _context;
        private IHostingEnvironment _env;

        public PollQuestionsController(DefaultDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet, Route("manage/pollQuestions/index")]
        [HttpGet, Route("manage/pollQuestions")]

        public IActionResult PollQuestions()
        {
            return View();
        }

        [HttpGet, Route("home/initialize")]
        public IActionResult Init()
        {
            var PollQuestion = this._context.PollQuestions.FirstOrDefault();
            if (PollQuestion == null)
            {
                PollQuestion pollQuestion = new PollQuestion()
                {
                    Id = Guid.Parse("3a88bea9-8a65-4c23-941a-972a6195b940"),
                    Timestamp = DateTime.UtcNow,
                    Title = "Saan mo gustong ganapin ang Christmas Party?",
                    Content = "Kung ikaw ay tatanungin saan mo gustong ganapin ang ating Christmas party, pumili ng isa.",
                    Thumbnail = null,
                    IsPublished = true,
                    PostExpiry = DateTime.UtcNow.AddDays(7),
                };
                this._context.PollQuestions.Add(PollQuestion);
            }

            
        } 






    }
}