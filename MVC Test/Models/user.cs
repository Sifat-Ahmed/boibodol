using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class User
    {
        // primary key for user model
        public int Id { get; set; }
        // Email address of the user
        public string Email { get; set; }
        // password of the user
        public string Password { get; set; }
        // status of the user if email verified or not
        public bool Verified { get; set; }
    }
}