namespace Szakdoga.Data
{
    public class Seged
    {
        public string Name { get; private set; }
        public string FoodName { get; private set; }
        public int Quantity { get; private set; }
        public int Price { get; private set; }
        public string Description { get; private set; }

        public Seged(OrderFood o)
        {
            using (SQL sql = SQL.InitMSSQL())
            {
                Order order = sql.Orders.Single(x => x.Id == o.OrderId);
                Name = sql.Tables.Single(x => x.Id == order.TableId).Name;

                FoodName = sql.Foods.Single(x => x.Id == o.FoodId).Name;
                Quantity = o.Quantity;
                Description = o.Description;
                Food f = sql.Foods.Single(x => x.Id == o.FoodId);
                Price = ((f.Price * o.Quantity) - o.Discount);

            }
        }
    }
}
