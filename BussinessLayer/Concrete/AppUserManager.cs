using BussinessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        public void AppUserAdd(AppUser user)
        {
            throw new NotImplementedException();
        }

        public void AppUserRemove(AppUser user)
        {
            throw new NotImplementedException();
        }

        public void AppUserUpdate(AppUser user)
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
