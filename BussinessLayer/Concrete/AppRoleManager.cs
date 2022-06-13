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
    /*ICategoryService
    {
        readonly ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryRepository)
        {
            this.categoryDal = categoryRepository;
        }*/

    public class AppRoleManager : IAppRoleService
    {
        readonly IAppRoleDal appRoleDal;

        public AppRoleManager(IAppRoleDal appRoleDal)
        {
            this.appRoleDal = appRoleDal;
        }

        public void AppRoleAdd(AppRole role)
        {
            appRoleDal.Insert(role);
        }

        public void AppRoleRemove(AppRole role)
        {
            appRoleDal.Delete(role);
        }

        public void AppRoleUpdate(AppRole role)
        {
            appRoleDal.Update(role);
        }

        public AppRole GetById(int id)
        {
            return appRoleDal.GetById(id);
        }

        public List<AppRole> GetList()
        {
            return appRoleDal.GetAll();
        }
    }
}
