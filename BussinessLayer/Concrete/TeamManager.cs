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
    public class TeamManager : ITeamService
    {
        readonly ITeamDal teamDal;
        public Team GetById(int id)
        {
            return teamDal.GetById(id);
        }

        public List<Team> GetList()
        {
            return teamDal.GetAll();
        }

        public void TeamAdd(Team team)
        {
            teamDal.Insert(team);
        }

        public void TeamRemove(Team team)
        {
            teamDal.Delete(team);
        }

        public void TeamUpdate(Team team)
        {
            teamDal.Update(team);
        }
    }
}
