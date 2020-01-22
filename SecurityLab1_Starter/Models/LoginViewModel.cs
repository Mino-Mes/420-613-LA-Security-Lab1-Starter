using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityLab1_Starter.Models
{
    public class LoginViewModel
    {
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
    }
}