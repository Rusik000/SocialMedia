using SocialProject.Core.DataAccess.EntityFramework;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.DataAccess.Concrete
{
    public class EfChatDal : EfEntityRepositoryBase<Chat, SocialDbContext>, IChatDal
    {

    }
}
