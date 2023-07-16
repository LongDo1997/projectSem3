using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("Image")]
    public class Image : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        [Required]
        public string FileName { get; set; }
        [Column(TypeName = "text")]
        public string? FilePath { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string? OrgFileName { get; set; }
    }
}
