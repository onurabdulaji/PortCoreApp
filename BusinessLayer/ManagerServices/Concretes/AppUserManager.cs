using BusinessLayer.ManagerServices.Abstracts;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Models;

namespace BusinessLayer.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _iappUserRepository; // Burada alir DAL'daki Interface'i Entity icin.

        public AppUserManager(IAppUserRepository iappUserRepository) : base(iappUserRepository)
        {
            _iappUserRepository = iappUserRepository;
        }

        public async Task<bool> CreateUser(AppUser item, string Password)
        {
            if (item.Email == null && item.UserName == null && Password == null)
            {
                return false;
            }
            var result = await _iappUserRepository.AddUser(item, Password);
            return result;
        }
    }
}
