using SULS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SULS.Services
{
    public interface IUserService
    {
        string CreateUser(string username, string email, string password);
        User GetUserOrNull(string username, string password);

        IQueryable<Problem> GetAllProblems();
    }
}
