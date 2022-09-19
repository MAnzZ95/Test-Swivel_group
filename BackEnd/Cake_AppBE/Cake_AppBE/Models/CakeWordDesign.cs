using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cake_AppBE.Models
{
    public class CakeWordDesign
    {
        [Key]
        public int WordId { get; set; }
        [MaxLength(20)]
        public string WordCount { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
    }
}
