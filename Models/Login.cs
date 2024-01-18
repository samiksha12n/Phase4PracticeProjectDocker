using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PracticeProjectDocker.Models
{
   
        [Table("Login")]
        public class Login
        {
            [Key]
            public int Id { get; set; }

            public string? Username { get; set; }

            public string? Email { get; set; }

            public string? Password { get; set; }

        }

    
}
