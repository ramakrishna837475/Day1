using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AMS_PRJ.Models
{
    public class Login
    {
        [Required(ErrorMessage = "please enter your name")]
        [Display(Name = " UserName :")]
        public string username { get; set; }


        [Required(ErrorMessage = "please enter your password")]
        [Display(Name = " Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}