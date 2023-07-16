using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models.Entity
{
    [Table("UserAccount")]
    public class UserAccount : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        [DefaultValue(1)]
        public byte Type { get; set; }
        [ForeignKey("Budget")]
        public int? BudgetId { get; set; }
        public virtual Budget? Budget { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderHistory> OrderHistorys { get; set; }
        public ICollection<FeedBack> FeedBacks { get; set; }

    }
}
