﻿using SocialProject.WebUI.Entities;
using System.Collections.Generic;

namespace SocialProject.WebUI.Helpers
{
    public static class UserHelper
    {
        public static CustomIdentityUser CurrentUser { get; set; }
        public static CustomIdentityUser ReceiverUser { get; set; }
        public static List<CustomIdentityUser> ActiveUsers { get; set; } = new List<CustomIdentityUser>();
    }
}
