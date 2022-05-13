using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public interface INotificationService
    {
        void Add(Notification notification);

        void Delete(Notification notification);

        void Update(Notification notification);

        List<Notification> GetAll();

        Notification GetById(int notificationId);

    }
}
