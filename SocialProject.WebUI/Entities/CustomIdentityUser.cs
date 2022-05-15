﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialProject.WebUI.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        public string ImageUrl { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public string Country { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }



    }
}
