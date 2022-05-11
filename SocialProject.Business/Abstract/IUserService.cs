using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public  interface IUserService
    {
        List<User> GetAll();        
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User GetById(int userId);
    }
}
