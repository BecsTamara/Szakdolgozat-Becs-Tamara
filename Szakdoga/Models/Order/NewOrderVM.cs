namespace Szakdoga.Models.Order
{
    public class NewOrderVM
    {
        public int TableId { get; set; }
        public IEnumerable<OrderFoodsVM> Foods { get; set; }
    }
}
