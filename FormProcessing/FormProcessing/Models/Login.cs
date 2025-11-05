using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormProcessing.Models
{
    public class Login
    {
        [Required]
        [StringLength(5)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}