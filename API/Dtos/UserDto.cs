using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class UserDto
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
