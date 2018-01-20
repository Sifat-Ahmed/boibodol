using System;
using System.Collections.Generic;
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
        public int CategoryId { get; set; }
        // type of the post. eg: buy , sell , review $$ Foreign Key
        public int PostTypeId { get; set; }
        // title of the post
        public string Title { get; set; }
        // post writer user id $$ Foreign Key
        public int AuthorId { get; set; }
        // post publish date
        public string Date { get; set; }
        // post body
        public string Details { get; set; }
        // post Thumbnail image
        public Image Thumbnail { get; set; }
        // post status ** applied only for sell/ exchange posts 
        public string Status { get; set; }
        // post approved by admin
        public bool IsApproved { get; set; }

    }
}