using BLL.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public class ProductListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Product_Id { get; set; }

        [DisplayName("Product name")]
        public string Name { get; set; }

        [DisplayName("Product description")]
        public string Description { get; set; }

        [DisplayName("Price in EUR - VAT incl.")]
        public decimal Price { get; set; }

        [DisplayName("Category identifier")]
        public int Category_Id { get; set; }

        [DisplayName("Eco-score")]
        public EcoScores EcoScore { get; set; }
    }
}