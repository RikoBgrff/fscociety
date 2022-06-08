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
    public class AppUserRepository : IAppUserDal
    {
        
        public void Delete(AppUser t)
        {
            using var context = new ApplicationDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<AppUser> GetAll()
        {
            using var context = new ApplicationDbContext();
            return context.Set<AppUser>().ToList();
        }

        public AppUser GetById(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Set<AppUser>().Find(id);
        }

        public void Insert(AppUser t)
        {
            using var context = new ApplicationDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(AppUser t)
        {
            using var context = new ApplicationDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
