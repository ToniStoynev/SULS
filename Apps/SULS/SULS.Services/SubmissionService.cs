using SULS.Data;
using SULS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SULS.Services
{
    public class SubmissionService : ISubmissionService
    {
        private readonly SULSContext db;

        public SubmissionService(SULSContext db)
        {
            this.db = db;
        }
        public Problem GetProblemById(string id)
        {
            return this.db.Problems.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
