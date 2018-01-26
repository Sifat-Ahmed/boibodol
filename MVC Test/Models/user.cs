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
        [Required(ErrorMessage = "Email Address is required.")]
        public string Email { get; set; }
        // password of the user
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password" , ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        // status of the user if email verified or not
        public bool Verified { get; set; }
    }
}