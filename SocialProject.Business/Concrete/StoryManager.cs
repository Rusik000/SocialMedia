using SocialProject.Business.Abstract;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Concrete
{
    public class StoryManager : IStoryService
    {

        private IStoryDal _storyDal;

        public StoryManager(IStoryDal storyDal)
        {
            _storyDal = storyDal;
        }

        public void Add(Story story)
        {
            _storyDal.Add(story);
        }

        public void Delete(Story story)
        {
            _storyDal.Delete(story);
        }

        public List<Story> GetAll()
        {
            return _storyDal.GetList();
        }

        public Story GetById(int storyId)
        {
            return _storyDal.Get(s => s.StoryId == storyId);
        }

        public void Update(Story story)
        {
            _storyDal.Update(story);
        }
    }
}
