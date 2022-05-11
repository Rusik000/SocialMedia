﻿using SocialProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialProject.Social.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Phonenumber { get; set; }

        public string ImagePath { get; set; }
    }
}
