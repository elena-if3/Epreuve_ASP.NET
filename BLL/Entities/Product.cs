namespace BLL.Entities
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public EcoScores EcoScore { get; set; }

        public Product(int product_Id, string name, string description, double price, string category, EcoScores ecoScore)
        {
            Product_Id = product_Id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            EcoScore = ecoScore;
        }
    }
}
