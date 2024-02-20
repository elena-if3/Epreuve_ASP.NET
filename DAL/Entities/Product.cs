namespace DAL.Entities
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string EcoScore { get; set; }
    }
}
