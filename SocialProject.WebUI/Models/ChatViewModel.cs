using SocialProject.WebUI.Entities;

namespace SocialProject.WebUI.Models
{
    public class ChatViewModel
    {
        public CustomIdentityUser ReceiverUser { get; set; }
        public CustomIdentityUser SenderUser { get; set; }
    }
}
