using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }

        public int UserId { get; set; }

        public string Message { get; set; }

        public DateTime DatePost { get; set; }

        public int Like { get; set; }

    }
}
