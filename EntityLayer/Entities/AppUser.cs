using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AppUser : IdentityUser, IEntity
    {
        int IEntity.Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Surename { get; set; }
        public string Biography { get; set; }
        public string ProfilePhoto { get; set; }
        public bool ProfileStatus { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public int Age { get; set; }
        public List<Post> LikedPosts { get; set; }
        public bool Status { get; set; }
         

    }
}
