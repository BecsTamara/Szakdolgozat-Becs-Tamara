using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Models.Order
{
    public class OrderVM
    {
        public Szakdoga.Data.Order order { get; set; }
        public Szakdoga.Data.OrderFood orderdfood { get; set; }
        public Szakdoga.Data.Food food { get; set; }
        public Szakdoga.Data.Table table { get; set; }
    }
}
