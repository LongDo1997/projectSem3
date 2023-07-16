using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("OrderDetail.cs")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [DefaultValue(1000)]
        public double Price { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; }
        [Column(TypeName = "text")]
        public string? ImageList { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int BookId { get; set; }
    }
}
