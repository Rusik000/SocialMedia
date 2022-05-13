using SocialProject.Business.Abstract;
using SocialProject.DataAccess.Abstract;
using SocialProject.Social.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Business.Concrete
{
    public class GroupManager: IGroupService
    {
        private IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        public void Add(Group group)
        {
            _groupDal.Add(group);
        }

        public void Delete(Group group)
        {
            _groupDal.Delete(group);
        }

        public List<Group> GetAll()
        {
            return _groupDal.GetList();
        }

        public Group GetById(int groupId)
        {
            return _groupDal.Get(g => g.GroupId == groupId);
        }

        public void Update(Group group)
        {
            _groupDal.Update(group);
        }
    }
}
