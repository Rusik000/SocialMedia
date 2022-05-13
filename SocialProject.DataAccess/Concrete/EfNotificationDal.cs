using SocialProject.Core.DataAccess.EntityFramework;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.DataAccess.Concrete
{
    public class EfNotificationDal:EfEntityRepositoryBase<Notification,SocialDbContext>,INotificationDal
    {

    }
}
