using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T t)
        {
            using var context = new ApplicationDbContext();
            context.Add(t);
            context.SaveChanges();
        }
        public void Update(T t)
        {
            using var context = new ApplicationDbContext();
            context.Update(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            using var context = new ApplicationDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new ApplicationDbContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Set<T>().Find(id);
        }


    }
}
