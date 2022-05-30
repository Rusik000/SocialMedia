using SocialProject.WebUI.Entities;
using System.Collections.Generic;

namespace SocialProject.WebUI.Services.Abstract
{
    public interface IFriendshipRepository
    {

        void Add(FriendShip item);
        void Delete(int id);
        void Update(FriendShip item);
        FriendShip Get(int id);
        IEnumerable<FriendShip> GetAll();
    }
}
