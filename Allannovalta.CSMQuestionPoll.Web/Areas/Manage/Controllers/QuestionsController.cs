using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Allannovalta.CSMQuestionPoll.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class QuestionsController : Controller
    {

        [HttpGet, Route("manage/questions/index")]
        [HttpGet, Route("manage/questions")]
        public IActionResult Index()
        {
            return View();
        }
    }
}