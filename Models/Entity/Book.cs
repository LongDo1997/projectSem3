using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column (TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string? Author { get; set; }
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }
        [DefaultValue(1000)]
        public double Price { get; set; }
        [Column(TypeName = "text")]
        public string? ImageList { get; set; }
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        //public ICollection<Flavour> Flavours { get; set;}
    }
}
