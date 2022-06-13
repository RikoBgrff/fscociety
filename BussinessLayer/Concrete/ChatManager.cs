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
    public class ChatManager : IChatService
    
{
        readonly IChatDal chatDal;

        public ChatManager(IChatDal chatDal)
        {
            this.chatDal = chatDal;
        }

        public void ChatAdd(Chat chat)
        {
            chatDal.Insert(chat);
        }

        public void ChatRemove(Chat chat)
        {
            chatDal.Delete(chat);
        }

        public void ChatUpdate(Chat chat)
        {
            chatDal.Update(chat);
        }

        public Chat GetById(int id)
        {
            return chatDal.GetById(id);
        }

        public List<Chat> GetList()
        {
            return chatDal.GetAll();
        }
    }
}
