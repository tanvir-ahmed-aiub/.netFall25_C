using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormProcessing.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Must give Id")]
        [Range(1,40)]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Format of Email not valid")]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
    }
}