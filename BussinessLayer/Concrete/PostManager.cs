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
    public class PostManager : IPostService
    {
        readonly IPostDal postDal;
        public PostManager(IPostDal postDal)
        {
            this.postDal = postDal;
        }

        public Post GetById(int id)
        {
           return postDal.GetById(id);
        }

        public List<Post> GetList()
        {
            return postDal.GetAll();
        }

        public void PostAdd(Post post)
        {
            postDal.Insert(post);
        }

        public void PostRemove(Post post)
        {
            postDal.Delete(post);
        }

        public void PostUpdate(Post post)
        {
            postDal.Update(post);
        }
    }
}
