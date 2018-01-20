using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class PostType
    {
        // Post type id. $$ Primary key
        public int Id { get; set; }
        // Name of the post type. eg: Buy , Sell , Review
        public string TypeName { get; set; }
    }
}