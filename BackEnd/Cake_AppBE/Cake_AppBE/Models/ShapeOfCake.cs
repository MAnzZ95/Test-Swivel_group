using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cake_AppBE.Models
{
    public class ShapeOfCake
    {
        [Key]
        public int ShepeId { get; set; }
        public string ShapeName { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

    }
}
