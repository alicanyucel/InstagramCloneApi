using InstagramCloneApi.Models;
using System.Collections.Generic;

namespace InstagramCloneApi.Dtos
{
    public class UsersDto
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
