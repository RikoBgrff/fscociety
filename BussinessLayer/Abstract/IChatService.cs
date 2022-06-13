using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IChatService
    {
        public void ChatAdd(Chat chat);
        public void ChatRemove(Chat chat);
        public void ChatUpdate(Chat chat);
        public Chat GetById(int id);
        public List<Chat> GetList();
    }
}
