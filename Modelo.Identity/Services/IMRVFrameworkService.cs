using MRV.Solution.Identity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MRV.Solution.Identity.Services
{
    public interface IMRVFrameworkService
    {
        Task<User> ValidarSenha(string login, string senha);
        Task<User> ValidarLogin(string login);
    }
}
