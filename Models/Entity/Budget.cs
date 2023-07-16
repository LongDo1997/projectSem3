using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("Budget")]
    public class Budget
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserAccount")]
        public int UserId { get; set; }
        [DefaultValue(0.0)]
        public double Balance { get; set; }
        public UserAccount UserAccount { get; set; }
        
    }
}
