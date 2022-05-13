using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Abstract
{
    public interface IGroupService
    {

        void Add(Group group);
        void Delete(Group group);

        void Update(Group group);

        List<Group> GetAll();

        Group GetById(int groupId);

    }
}
