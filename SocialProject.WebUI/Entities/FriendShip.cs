using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SocialProject.WebUI.Entities
{
    public class FriendShip
    {
        public int FriendShipId { get; set; }
        public string SenderId { get; set; }
        public string FriendId { get; set; }
        public virtual CustomIdentityUser Sender { get; set; }
        public virtual CustomIdentityUser Friend { get; set; }

        public bool Accepted { get; set; }

    }
}
