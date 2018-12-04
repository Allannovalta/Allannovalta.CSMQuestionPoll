using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Allannovalta.CSMQuestionPoll.Web.Models;

namespace Allannovalta.CSMQuestionPoll.Web.Controllers
{
    public class HomeController : Controller
    {

        

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet, Route("areas/manage/views/users")]
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
