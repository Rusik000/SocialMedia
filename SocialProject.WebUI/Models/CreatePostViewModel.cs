using Microsoft.AspNetCore.Http;
using SocialProject.WebUI.Entities;
using System;
using System.Collections.Generic;

namespace SocialProject.WebUI.Models
{
    public class CreatePostViewModel
    {
        public List<Post> Posts { get; set; }

        public List<CustomIdentityUser> Users { get; set; }
        public List<FriendShip> FriendShips { get; set; }

        public CustomIdentityUser CurrentUser { get; set; }
        public string Message { get; set; }
        public string PostImage { get; set; }

        public string VideoLink { get; set; }
        public IFormFile File { get; set; }

    }
}
