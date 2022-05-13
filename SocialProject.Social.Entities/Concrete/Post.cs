using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public class Post : IEntity
    {
        public int PostId { get; set; }

        public int UserId { get; set; }
        public string Message { get; set; }
        public int CommentId { get; set; }

        public string ImagePath { get; set; }

        public DateTime CreatedTime { get; set; }

        public int Like { get; set; }
    }
}
