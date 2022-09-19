using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cake_AppBE.Models
{
    public class SizeOfCake
    {
        [Key]
        public int SizeId { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

    }
}
