using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        //[ForeignKey("User")]
        //[Key]
        public int UserId { get; set; }
        
        
        // Name of the user
        public string Name { get; set; }
        
        
        // Address of the user
        public string Address { get; set; }
        
        
        // Phone number of the user
        public string Phone { get; set; }
        // profile image of the user
        // public Image ProfileImage { get; set; }


        // *************************************** //
        // *****Check Book.Cs for Explanation***** //
        // *************************************** //

        // Getting the user from user table
        public User User { get; set; }


    }
}