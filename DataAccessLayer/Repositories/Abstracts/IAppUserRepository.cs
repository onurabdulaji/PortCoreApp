using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstracts
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<bool> AddUser(AppUser item, string Password);
    }
}
