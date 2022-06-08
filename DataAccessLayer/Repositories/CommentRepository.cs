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
    public class CommentRepository : ICommentDal
    {
   
        public void Delete(Comment t)
        {
            using var context = new ApplicationDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            using var context = new ApplicationDbContext();
            return context.Set<Comment>().ToList();
        }

        public Comment GetById(int id)
        {
            using var context = new ApplicationDbContext();
            return context.Set<Comment>().Find(id);
        }

        public void Insert(Comment t)
        {
            using var context = new ApplicationDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(Comment t)
        {
            using var context = new ApplicationDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
