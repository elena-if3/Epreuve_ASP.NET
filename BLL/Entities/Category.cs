using System;
using System.Collections.Generic;

namespace BLL.Entities
{
    public class Category
    {
        private List<Product> _products;
        public int Cat_Id { get; set; }
        public string CatName { get; set; }
        public string? CatDescr { get; set; }
        public Product[] Products
        {
            get
            {
                return _products?.ToArray() ?? new Product[0];
            }
        }

        public Category(int cat_Id, string catName, string? catDescr)
        {
            Cat_Id = cat_Id;
            CatName = catName;
            CatDescr = catDescr;
        }

        public void AddProduct(Product product)
        {
            _products ??= new List<Product>();
            _products.Add(product);
        }

        public void AddProducts(IEnumerable<Product> products)
        {
            if (products is null) throw new ArgumentNullException(nameof(products));
            foreach (var product in products)
            {
                AddProduct(product);
            }
        }

        public void RemoveProduct(Product product)
        {
            _products?.Remove(product);
        }

        public void Clear()
        {
            _products?.Clear();
        }
    }
}
