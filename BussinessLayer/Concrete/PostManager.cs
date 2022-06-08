using BussinessLayer.Abstract;
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
        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetList()
        {
            throw new NotImplementedException();
        }

        public void PostAdd(Post post)
        {
            throw new NotImplementedException();
        }

        public void PostRemove(Post post)
        {
            throw new NotImplementedException();
        }

        public void PostUpdate(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
