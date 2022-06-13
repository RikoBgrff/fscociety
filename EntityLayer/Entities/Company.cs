using EntityLayer.HelperEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Company:Entity
    {
        public string Country { get; set; }
        public List<AppUser> Admins { get; set; }
        public List<AppUser> Moderators { get; set; }
        public List<Job> Jobs { get; set; }
        public List<FreelanceWork> FreelanceWorks { get; set; }
        public AddressInformation Address { get; set; }
        public ContactInformation Contact { get; set; }

    }
}
