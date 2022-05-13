using SocialProject.Business.Abstract;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Concrete
{
    public class ChatManager : IChatService
    {

        private IChatDal _chatDal;

        public ChatManager(IChatDal chatDal)
        {
            _chatDal = chatDal;
        }

        public void Add(Chat chat)
        {
            _chatDal.Add(chat);
        }

        public void Delete(Chat chat)
        {
            _chatDal.Delete(chat);
        }

        public List<Chat> GetAll()
        {
            return _chatDal.GetList();
        }

        public Chat GetById(int chatId)
        {
            return _chatDal.Get(c => c.ChatId == chatId);
        }

        public void Update(Chat chat)
        {
            _chatDal.Update(chat);
        }
    }
}
