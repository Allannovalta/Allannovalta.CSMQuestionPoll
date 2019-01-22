using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models;
using Allannovalta.CSMQuestionPoll.Web.ViewModels.PollQuestions;
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

        #region Pager
        public IActionResult PollQuestions(int pageSize = 5, int pageIndex = 1, string keyword = "")
        {
            Page<PollQuestion> result = new Page<PollQuestion>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }
            IQueryable<PollQuestion> pollQuestionQuery = (IQueryable<PollQuestion>)this._context.PollQuestions;
            if (string.IsNullOrEmpty(keyword) == false)
            {
                pollQuestionQuery = pollQuestionQuery.Where(u => u.Title.Contains(keyword)
                                            || u.Title.Contains(keyword)
                                            || u.Content.Contains(keyword));
            }
            long queryCount = pollQuestionQuery.Count();
            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);
            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }
            int skip = (int)(pageSize * (pageIndex - 1));
            List<PollQuestion> pollQuestions = pollQuestionQuery.ToList();
            result.Items = pollQuestions.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.CurrentPage = pageIndex;

            return View(new PollQuestionViewModel()
            {
                PollQuestions = result
            });
        }
        #endregion

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
                this._context.PollQuestions.Add(pollQuestion);

                this._context.SaveChanges();
            }

            return RedirectToAction("pollQuestions");
        }

        [HttpGet, Route("manage/pollQuestions")]
        public IActionResult Create(CreatePollQuestionViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("pollQuestion");
            
            
            
               var pollQuestion = new PollQuestion()
                {
                    Title = model.Title,
                    Content = model.Content,
                    Thumbnail = model.Thumbnail,
                    IsPublished = model.Ispublished,
                    PostExpiry = model.PostExpiry,
                };
                this._context.PollQuestions.Add(pollQuestion);
                this._context.SaveChanges();
            
            return RedirectToAction("index");

        }

    }
}