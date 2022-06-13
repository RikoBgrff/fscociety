using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IFreelanceWorkService
    {
        public void FreelanceWorkAdd(FreelanceWork work);
        public void FreelanceWorkRemove(FreelanceWork work);
        public void FreelanceWorkUpdate(FreelanceWork work);
        public FreelanceWork GetById(int id);
        public List<FreelanceWork> GetList();
    }
}
