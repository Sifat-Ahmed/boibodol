using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class Book
    {
        // primary key post id $$ Primary Key
        public int Id { get; set; }
        // category of the post. eg: horror , novel $$ Foreign Key 
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        // type of the post. eg: buy , sell , review $$ Foreign Key
        //[ForeignKey("PostType")]
        public int PostTypeId { get; set; }
        // title of the post
        public string Title { get; set; }
        // post writer user id $$ Foreign Key
        public int UserId { get; set; }
        // post publish date
        public string Date { get; set; }
        // post body
        public string Details { get; set; }
        // post Thumbnail image
        // public Image Thumbnail { get; set; }
        // post status ** applied only for sell/ exchange posts 
        public string Status { get; set; }
        // post approved by admin
        public bool IsApproved { get; set; }
        // if sell post then there should be a price
        public decimal Price { get; set; }


        // These are the navigation property
        // A navigation property lets you access other tabels directly from this class

        // If I add Category Class here then The CategoryName for This post will
        // be visible here through Navigation property.

        public Category Category { get; set; }

        // for each post there is a user who has written it
        // This class below keeps the track of the user who has written the post by making a 
        // relationship among the Book and User class with a Foreign Key Attribute
        public User User { get; set; }

        // Same as above
        // Keeping the track of the category
        public PostType PostType { get; set; }

        // *************************************** //

        // Please understand these As an Individual Post
        // What happens when you post an Individual post???
        // It has some attributes that are taken from other Classes(Entities)
        // We know them as foreign key attribute
        // We are making foreign key relationships here.



    }
}