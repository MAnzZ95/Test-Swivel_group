using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cake_AppBE.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [MaxLength(200)]
        public string FirstName { get; set; }
        [MaxLength(300)]
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
