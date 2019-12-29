using System;
using System.ComponentModel.DataAnnotations;

namespace Dating.Api.Dtos
{
    public class UserRegisterDto
    {
        [Required]        
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characteres")]
        public string Password { get; set; }
    }
}
