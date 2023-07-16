using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("Recipe")]
    public class Recipe : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column (TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }
        [Column(TypeName = "tinyint")]
        [DefaultValue(1)]
        public byte? AccessType { get; set; }
        [Column(TypeName = "text")]
        public string? ImageList { get; set; }
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        //public ICollection<Flavour> Flavours { get; set;}
    }
}
