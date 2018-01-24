using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Test.Models
{
    public class Contact
    {
        // This model collect data from COntact us from.

        // ID of the Contact Submission
        public int Id { get; set; }
        // Name of The advisor
        public string Name { get; set; }
        // Email
        public string Email { get; set; }
        // Phone
        public string Phone { get; set; }
        // Comment
        public string Comment { get; set; }
    }
}