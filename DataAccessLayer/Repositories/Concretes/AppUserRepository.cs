using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;
        public AppUserRepository(MyContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> AddUser(AppUser item, string Password)
        {
            IdentityResult result = await _userManager.CreateAsync(item, Password);
            if (result.Succeeded) return true;
            return false;
        }

        public async Task<bool> LoginUser(string userName, string password)
        {
            var logiResult = await _signInManager.PasswordSignInAsync(userName, password, false, false);
            if (logiResult.Succeeded) return true;
            return false;
        }
    }
}
