namespace DAL.Entities
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Category_Id { get; set; }
        public string EcoScore { get; set; }
    }
}
