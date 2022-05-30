using SocialProject.WebUI.Entities;
using SocialProject.WebUI.Services.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SocialProject.WebUI.Services.Concrete
{
    public class FriendshipRepository : IFriendshipRepository
    {

        private CustomIdentityDbContext _context;

        public FriendshipRepository(CustomIdentityDbContext context)
        {
            _context = context;
        }

        public void Add(FriendShip friend)
        {
            _context.FriendShips.Add(friend);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            foreach (var item in _context.FriendShips)
            {
                if (item.FriendShipId == id)
                {
                    _context.Remove(item);
                }
            }
            _context.SaveChanges();
        }

        public FriendShip Get(int id)
        {
            foreach (var item in _context.FriendShips)
            {
                if (item.FriendShipId == id)
                {
                    return item;
                }

            }
            return null;
        }

        public IEnumerable<FriendShip> GetAll()
        {
            return _context.FriendShips.ToList();
        }

        public void Update(FriendShip friend)
        {
            foreach (var item in _context.FriendShips)
            {
                if (item.FriendShipId == friend.FriendShipId)
                {
                    item.SenderId = friend.SenderId;
                    item.FriendId = friend.FriendId;
                    item.Accepted = friend.Accepted;
                }

            }
            _context.SaveChanges();
        }
    }
}
