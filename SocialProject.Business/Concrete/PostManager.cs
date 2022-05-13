using SocialProject.Business.Abstract;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public void Add(Post post)
        {
            _postDal.Add(post);
        }

        public void Delete(Post post)
        {
            _postDal.Delete(post);
        }

        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public Post GetById(int postId)
        {
            return _postDal.Get(p => p.PostId == postId);
        }

        public void Update(Post post)
        {
            _postDal.Update(post);
        }
    }
}
