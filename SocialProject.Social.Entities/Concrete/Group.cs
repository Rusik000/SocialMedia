using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public class Group : IEntity
    {
        public int GroupId { get; set; }
        public string UserId { get; set; }

        public string Name { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}
