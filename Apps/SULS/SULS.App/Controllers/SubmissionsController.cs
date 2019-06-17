using SIS.MvcFramework;
using SIS.MvcFramework.Result;
using SULS.App.ViewModels.Submissions;
using SULS.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SULS.App.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly IProblemService problemService;
        private readonly ISubmissionService submissionService;

        public SubmissionsController(IProblemService problemService, ISubmissionService submissionService)
        {
            this.problemService = problemService;
            this.submissionService = submissionService;
        }
        public IActionResult Create(string id)
        {
            var problem = this.submissionService.GetProblemById(id);
            var viewModel = new CreateSubmissionViewModel
            {
                ProblemId = problem.Id,
                Name = problem.Name
            };
            return this.View(viewModel);
        }


    }
}
