using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public interface IStoryService
    {
        void Add(Story story);
        void Delete(Story story);
        void Update(Story story);
        List<Story> GetAll();
        Story GetById(int storyId);


    }
}
