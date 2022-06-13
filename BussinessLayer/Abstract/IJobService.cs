using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IJobService
    {
        public void JobAdd(Job job);
        public void JobRemove(Job job);
        public void JobUpdate(Job job);
        public Job GetById(int id);
        public List<Job> GetList();

    }
}
