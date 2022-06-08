using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string ConcurrencyStamp { get; set; }
        public bool Status { get; set; }

    }
}
