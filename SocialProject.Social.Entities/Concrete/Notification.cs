using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public  class Notification:IEntity 
    {
        public int NotificationId { get; set; }


        public int UserId { get; set; }

        public string Message { get; set; }
        public DateTime CurrentTime { get; set; }


    }
}
