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
        [UIHint("MultilineText")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* Email Required")]
        [UIHint("MultilineText")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Subject Required")]
        [UIHint("MultilineText")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "* Message Required")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}