using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface  ITeamService
    {
        public void TeamAdd(Team team);
        public void TeamRemove(Team team);
        public void TeamUpdate(Team team);
        public Team GetById(int id);
        public List<Team> GetList();
    }
}
