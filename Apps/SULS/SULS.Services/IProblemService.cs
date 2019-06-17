using SULS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SULS.Services
{
    public interface IProblemService
    {
        void CreateProblem(string name, int totalPoints);

        IQueryable<Submission> GetAllSubmissionById(string id);

        void GetProblemById(string id);
    }
}
