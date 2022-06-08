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
    public class PostRepository : IPostDal
    {

        public void Delete(Post t)
        {
            using var context = new ApplicationDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<Post> GetAll()
        {
            using var context = new ApplicationDbContext();
            return context.Set<Post>().ToList();
        }

        public Post GetById(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Set<Post>().Find(id);
        }

        public void Insert(Post t)
        {
            using var context = new ApplicationDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(Post t)
        {
            using var context = new ApplicationDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}