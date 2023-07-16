using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("FeedBack")]
    public class FeedBack : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        [StringLength(200)]
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "tinyint")]
        [DefaultValue(1)]
        public byte? Star { get; set; }
        public string? ImageList { get; set; }
        public int? BookId { get; set; }
        public int? RecipeId { get; set; }
        [ForeignKey("UserAccount")]
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        
    }
}
