namespace BLL.Entities
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Category_Id { get; set; }
        public EcoScores EcoScore { get; set; }

        public Product(int product_Id, string name, string description, decimal price, int category_Id, EcoScores ecoScore)
        {
            Product_Id = product_Id;
            Name = name;
            Description = description;
            Price = price;
            Category_Id = category_Id;
            EcoScore = ecoScore;
        }
    }
}
