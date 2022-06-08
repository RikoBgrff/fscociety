using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IAppRoleService
    {
        void AppRoleAdd(AppRole role);
        void AppRoleRemove(AppRole role);
        void AppRoleUpdate(AppRole role);
        List<AppRole> GetList();
        AppRole GetById(int id);
    }
}
