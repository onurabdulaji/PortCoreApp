using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Abstracts
{
    public interface IAppUserManager : IManager<AppUser>
    {
        Task<bool> CreateUser(AppUser item, string Password);
        Task<bool> LoginUser(string userName, string password);
    }
}
