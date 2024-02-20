namespace BLL.Entities
{
    public class PartialOrder
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Amount { get; set; }

        public PartialOrder(int id, int product_Id, int amount)
        {
            Id = id;
            Product_Id = product_Id;
            Amount = amount;
        }
    }
}
