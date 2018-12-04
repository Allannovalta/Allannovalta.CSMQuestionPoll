using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Allannovalta.CSMQuestionPoll.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PollQuestionsController : Controller
    {

        [HttpGet, Route("manage/pollQuestions/index")]
        [HttpGet, Route("manage/pollQuestions")]
        public IActionResult pollQuestions()
        {
            return View();
        }
    }
}