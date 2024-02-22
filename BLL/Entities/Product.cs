using System;
using System.Collections.Generic;

namespace BLL.Entities
{
    public class Product
    {
        private List<Media> _medias;
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Category_Id { get; set; }
        public EcoScores EcoScore { get; set; }
        public Category Category { get; set; }
        public Media[] Medias
        {
            get
            {
                return _medias?.ToArray() ?? new Media[0];
            }
        }

        public Product(int product_Id, string name, string description, decimal price, int category_Id, EcoScores ecoScore)
        {
            Product_Id = product_Id;
            Name = name;
            Description = description;
            Price = price;
            Category_Id = category_Id;
            EcoScore = ecoScore;
        }

        public Product(int product_Id, string name, string description, decimal price, int category_Id, EcoScores ecoScore, Category category)
        {
            Product_Id = product_Id;
            Name = name;
            Description = description;
            Price = price;
            Category_Id = category_Id;
            EcoScore = ecoScore;
            Category = category;
        }

        public void AddMedia(Media media)
        {
            _medias ??= new List<Media>();
            _medias.Add(media);
        }

        public void AddMedias(IEnumerable<Media> medias)
        {
            if (medias is null) throw new ArgumentNullException(nameof(medias));
            foreach (Media media in medias)
            {
                AddMedia(media);
            }
        }
    }
}
