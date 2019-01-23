using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Models;
//using Allannovalta.CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using Allannovalta.CSMQuestionPoll.Web.ViewModels.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Allannovalta.CSMQuestionPoll.Web.Areas.Controllers
{
    [Area("Manage")]
    public class UsersController : Controller
    {
        private readonly DefaultDbContext _context;
        private readonly IHostingEnvironment _env;

        //public UsersController(DefaultDbContext context)
        //{
        //    _context = context;
        //}

        public UsersController(DefaultDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet, Route("manage/users/index")]
        [HttpGet, Route("manage/users")]
        
        
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "")
        {
            Page<User> result = new Page<User>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }
            IQueryable<User> userQuery = (IQueryable<User>)this._context.Users;
            if (string.IsNullOrEmpty(keyword) == false)
            {
                userQuery = userQuery.Where(u => u.FirstName.Contains(keyword)
                                            || u.LastName.Contains(keyword)
                                            || u.EmailAddress.Contains(keyword));
            }
            long queryCount = userQuery.Count();
            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);
            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }
            int skip = (int)(pageSize * (pageIndex - 1));
            List<User> users = userQuery.ToList();
            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.CurrentPage = pageIndex;

            //var users = this._context.Users.ToList();
            return View(new IndexViewModel()
            {
                Users = result
            });
        }

        [HttpGet, Route("manage/users/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/users/create")]
        public IActionResult Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("index");

            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Password does not match Password Confirmation");
                return View();
            }

            var user = this._context.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower());

            if (user == null)
            {
                user = new User()
                {
                    EmailAddress = model.EmailAddress,
                    Password = model.Password,
                    Gender = model.Gender,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };
                this._context.Users.Add(user);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }

    }
}