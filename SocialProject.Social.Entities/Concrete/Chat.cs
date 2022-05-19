using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public class Chat : IEntity
    {
        public int ChatId { get; set; }
        public string UserId { get; set; }

        public string Message { get; set; }

        public string ImagePath { get; set; }
        public DateTime SendedTime { get; set; }

    }
}
