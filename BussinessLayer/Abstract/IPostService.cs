using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IPostService
    {
        void PostAdd(Post post);
        void PostRemove(Post post);
        void PostUpdate(Post post);
        List<Post> GetList();
        Post GetById(int id);
    }
}
