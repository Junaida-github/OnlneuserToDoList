using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineUsrToDoLst.Models
{
    public class RegistrationModel
    {
            [Required]
            public string DisplayName { get; set; }
            [Required]
            public string Password { get; set; }
            [Required]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
    }

    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class ToDos
    {
        public int ToDoId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public System.DateTime DueDate { get; set; }
    }
}