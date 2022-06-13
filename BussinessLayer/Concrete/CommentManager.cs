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
    public class CommentManager : ICommentService
    {
        readonly ICommentDal commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            commentDal.Insert(comment);
        }

        public void CommentRemove(Comment comment)
        {
            commentDal.Delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            commentDal.Update(comment);
        }

        public Comment GetById(int id)
        {
            return commentDal.GetById(id);
        }

        public List<Comment> GetList()
        {
            return commentDal.GetAll();
        }
    }
}
