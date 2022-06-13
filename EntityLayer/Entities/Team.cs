using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Team:Entity
    {
        public List<AppUser> Members { get; set; }
        public List<AppUser> Admins { get; set; }
        public List<FreelanceWork> Works { get; set; }
    }
}
