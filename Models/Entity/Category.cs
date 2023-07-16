using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
    }
}
