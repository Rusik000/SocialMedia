using SocialProject.Business.Abstract;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Concrete
{
    public class NotificationManager : INotificationService
    {

        private INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification notification)
        {
            _notificationDal.Add(notification);
        }

        public void Delete(Notification notification)
        {
            _notificationDal.Delete(notification);
        }

        public List<Notification> GetAll()
        {
            return _notificationDal.GetList();
        }

        public Notification GetById(int notificationId)
        {
            return _notificationDal.Get(n => n.NotificationId == notificationId);
        }

        public void Update(Notification notification)
        {
            _notificationDal.Update(notification);
        }
    }
}
