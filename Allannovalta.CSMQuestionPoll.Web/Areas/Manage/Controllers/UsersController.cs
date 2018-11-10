using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allannovalta.CSMQuestionPoll.Web.Areas.Manage.Infrastructure.Data.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Allannovalta.CSMQuestionPoll.Web.Areas.Manage.Controllers
{
    public class UsersController : Controller
    {
        private readonly DefaultDbContext _context;
        public UsersController(DefaultDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = this._context.Users.ToList();
            return View();
        }
    }
}