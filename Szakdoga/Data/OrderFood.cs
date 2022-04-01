using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Data
{
    public class OrderFood : BaseEntity
    {
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }

        public int Discount { get; set; } = 0;
    }
}
