using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
        Post GetById(int postId);
    }
}
