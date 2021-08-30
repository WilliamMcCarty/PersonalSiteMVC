using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSiteMVC.UI.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Name Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Subject Required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "* Message Required")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}