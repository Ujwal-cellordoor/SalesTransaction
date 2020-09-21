using System;

using System.ComponentModel.DataAnnotations;

namespace SalesTransaction.Application.Models
{
    public class UsersClass
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please Enter UserName!!")]
        [Display(Name = "User Name")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter the UserName!!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}

