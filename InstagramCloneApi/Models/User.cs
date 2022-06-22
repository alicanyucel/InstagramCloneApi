using System.Collections.Generic;

namespace InstagramCloneApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public string UserEmail { get; set; }
        public string UserLastName { get; set; }

        public List<Photo> Photos { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
