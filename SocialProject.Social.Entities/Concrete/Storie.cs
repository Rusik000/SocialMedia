using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public class Story : IEntity
    {
        public int StoryId { get; set; }
        public string UserId { get; set; }

        public string ImagePath { get; set; }
        public string BackgroundImagePath { get; set; }

        public DateTime CreatedTime { get; set; }
        public string Message { get; set; }
    }
}
