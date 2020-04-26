using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication1.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage ="Username is mandatory")]
        [Display(Name ="Enter User Name")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password is mandatory")]
        [Display(Name ="Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}