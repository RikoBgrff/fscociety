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
    internal class JobManager : IJobService
    {
        readonly IJobDal jobDal;
        public Job GetById(int id)
        {
         return jobDal.GetById(id);
        }

        public List<Job> GetList()
        {
            return jobDal.GetAll();
        }

        public void JobAdd(Job job)
        {
            jobDal.Insert(job);
        }

        public void JobRemove(Job job)
        {
            jobDal.Delete(job);
        }

        public void JobUpdate(Job job)
        {
            jobDal.Update(job);
        }
    }
}
