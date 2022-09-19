using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cake_AppBE.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal OrderAmount { get; set; }
        
        [MaxLength(20)]
        public string Message { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        public User User { get; set; }
    }
}
