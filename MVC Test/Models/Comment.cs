using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class Comment
    {
        // primary key comment ID
        public int Id { get; set; }
        // Pid of the post where user commented
        public int PostId { get; set; }
        // type of the post eg: buy , sell , exchange
        public int PostTypeId { get; set; }
        // comment text
        public string CommentText { get; set; }
        // date of the comment
        public string Date { get; set; }
    }
}