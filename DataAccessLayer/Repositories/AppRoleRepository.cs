using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AppRoleRepository : IAppRoleDal
    {
     
        public void Delete(AppRole t)
        {
            using var context = new ApplicationDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<AppRole> GetAll()
        {
            using var context = new ApplicationDbContext();
            return context.Set<AppRole>().ToList();
        }

        public AppRole GetById(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Set<AppRole>().Find(id);
        }

        public void Insert(AppRole t)
        {
            using var context = new ApplicationDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(AppRole t)
        {
            using var context = new ApplicationDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
