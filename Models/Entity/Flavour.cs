using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("Flavour")]
    public class Flavour : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }
        public string? ImageList { get; set; }
        //public ICollection<Recipe> Recipes { get; set; }
    }
}
