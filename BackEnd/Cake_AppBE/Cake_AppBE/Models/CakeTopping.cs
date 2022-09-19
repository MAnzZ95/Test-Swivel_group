using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cake_AppBE.Models
{
    public class CakeTopping
    {
        [Key]
        public int ToppingId { get; set; }
        [Required]
        public string ToppingSize { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

    }
}
