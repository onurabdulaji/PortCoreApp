using BusinessLayer.ManagerServices.Abstracts;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Concretes
{
    public class AppRoleManager : BaseManager<AppRole>, IAppRoleManager
    {
        IAppRoleRepository _iappRoleRepository; // Burada alir DAL'daki Interface'i Entity icin.

        public AppRoleManager(IAppRoleRepository iappRoleRepository) : base(iappRoleRepository)
        {
            _iappRoleRepository = iappRoleRepository;
        }
    }
}
