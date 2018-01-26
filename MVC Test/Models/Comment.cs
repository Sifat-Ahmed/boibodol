using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class Comment
    {
        // primary key comment ID
        public int Id { get; set; }
        
        // Pid of the post where user commented
        //[ForeignKey("Book")]
        public int PostId { get; set; }
        

        // type of the post eg: buy , sell , exchange
        //[ForeignKey("PostType")]
        public int PostTypeId { get; set; }
        

        // Id of the User who made comments
        //[ForeignKey("User")]
        public int UserId { get; set; }
        

        // comment text
        public string CommentText { get; set; }
        

        // date of the comment
        public string Date { get; set; }


        // *************************************** //
        // *****Check Book.Cs for Explanation***** //
        // *************************************** //

        // Getting the The post where the comment has been made
        public Book Book { get; set; }

        // Getting the post type Id
        public PostType PostType { get; set; }

        // Getting the attrbutes of the user
        public User User { get; set; }



    }
}