using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webt.Models
{
    public class UserProfileClass
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        public string Views { get; set; }
        public string ReturnView()
        {
            string View;
            View = " "; 
            if ((Email=="narmbuyu@gmail.com") && (Password=="123456789"))
            {
                View = "Admin";
            }
            if ((Email == "ayanda@gmail.com") && (Password == "123456789"))
            {
                View = "Technician";
            }
            else if ((Email == "rovanya@gmail.com") && (Password == "123456789"))
            {
                View = "Customer";
            }
            return (View);
        }
        
    }
}