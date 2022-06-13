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
    public class FreelanceWorkManager : IFreelanceWorkService
    {
        readonly IFreelanceWorkDal workDal;
        public void FreelanceWorkAdd(FreelanceWork work)
        {
            workDal.Insert(work);
        }

        public void FreelanceWorkRemove(FreelanceWork work)
        {
            workDal.Delete(work);
        }

        public void FreelanceWorkUpdate(FreelanceWork work)
        {
            workDal.Update(work);
        }

        public FreelanceWork GetById(int id)
        {
            return workDal.GetById(id);
        }

        public List<FreelanceWork> GetList()
        {
            return workDal.GetAll();
        }
    }
}
