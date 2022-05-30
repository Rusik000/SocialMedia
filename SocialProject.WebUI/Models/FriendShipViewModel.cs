using SocialProject.WebUI.Entities;
using System.Collections.Generic;

namespace SocialProject.WebUI.Models
{
    public class FriendShipViewModel
    {
        public List<CustomIdentityUser> Friends { get; set; }
        public List<FriendShip> FriendShips { get; set; }

        public CustomIdentityUser CurrentUser { get; set; }

        public List<CustomIdentityUser> Users { get; set; }




    }
}
