using SULS.Data;
using SULS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SULS.Services
{
    public class ProblemService : IProblemService
    {
        private readonly SULSContext db;

        public ProblemService(SULSContext db)
        {
            this.db = db;
        }
        public void CreateProblem(string name, int totalPoints)
        {
            var problem = new Problem
            {
                Name = name,
                Points = totalPoints
            };
            this.db.Problems.Add(problem);
            this.db.SaveChanges();
        }

        public IQueryable<Submission> GetAllSubmissionById(string id)
        {
            return this.db.Submissions.Where(x => x.ProblemId == id);
        }

        public void GetProblemById(string id)
        {
            var problem = this.db.Problems.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
