﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class UserDetails
    {
        // Id for this entity. $$ Foreign key
        public int Id { get; set; }
        // Id from user entity $$ Foreign Key
        public int UserId { get; set; }
        // Name of the user
        public string Name { get; set; }
        // Address of the user
        public string Address { get; set; }
        // Phone number of the user
        public string Phone { get; set; }
        // profile image of the user
        // public Image ProfileImage { get; set; }

        // No Primary key attached 
    }
}