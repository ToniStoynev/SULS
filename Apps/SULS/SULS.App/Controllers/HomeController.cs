using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Result;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;
using SULS.Services;
using System.Linq;
using SULS.App.ViewModels.Problems;

namespace SULS.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()
        {
            return this.Index();
        }

        // /Home/Index
        public IActionResult Index()
        {
            if (!this.IsLoggedIn())
            {
                return this.View();
            }
            else
            {
                var problem = this.userService.GetAllProblems()
                .Select(x => new ProblemViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Count = x.Submissions.Count
                }).ToList();
                return this.View(problem, "IndexLoggedIn");
            }
        }
    }
}