using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(Comment comment);

        void Update(Comment comment);

        List<Comment> GetAll();
        Comment GetById(int commentId);



    }
}
