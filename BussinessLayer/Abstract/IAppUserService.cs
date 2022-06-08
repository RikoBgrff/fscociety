using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IAppUserService
    {
        void AppUserAdd(AppUser user);
        void AppUserRemove(AppUser user);
        void AppUserUpdate(AppUser user);
        List<AppUser> GetList();
        AppUser GetById(int id);
    }
}
