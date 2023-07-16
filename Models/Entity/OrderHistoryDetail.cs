using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("OrderHistoryDetail")]
    public class OrderHistoryDetail
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
        [ForeignKey("OrderHistory")]
        public int OrderHistoryId { get; set; }
        public OrderHistory OrderHistory { get; set; }
        public int BookId { get; set; }
    }
}
