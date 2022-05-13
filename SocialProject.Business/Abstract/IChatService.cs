using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public interface IChatService
    {
        void Add(Chat chat);
        void Delete(Chat chat);
        void Update(Chat chat);

        List<Chat> GetAll();
        Chat GetById(int chatId);
    }
}
