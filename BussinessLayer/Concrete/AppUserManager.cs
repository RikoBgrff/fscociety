using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        readonly IAppUserDal appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            this.appUserDal = appUserDal;
        }

        public void AppUserAdd(AppUser user)
        {
            appUserDal.Insert(user);
        }

        public void AppUserRemove(AppUser user)
        {
            appUserDal.Delete(user);
        }

        public void AppUserUpdate(AppUser user)
        {
            appUserDal.Update(user);
        }

        public AppUser GetById(int id)
        {
            return appUserDal.GetById(id);
        }

        public List<AppUser> GetList()
        {
            return appUserDal.GetAll();
        }
    }
}
