using BLL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Models
{
    public class ProductEditForm
    {
        [HiddenInput]
        [Required]
        public int Product_Id { get; set; }

        [DisplayName("Product name")]
        [Required(ErrorMessage = "Mandatory field!")]
        [MaxLength(50, ErrorMessage = "The product name must have a maximum of 50 characters.")]
        [MinLength(2, ErrorMessage = "The product name must have a minimum of 2 characters.")]
        public string Name { get; set; }

        [DisplayName("Product description")]
        [Required(ErrorMessage = "Mandatory field!")]
        [MaxLength(1000, ErrorMessage = "The product name must have a maximum of 1000 characters.")]
        [MinLength(20, ErrorMessage = "The product name must have a minimum of 20 characters.")]
        public string Description { get; set; }

        [DisplayName("Price in EUR - VAT incl.")]
        [Required(ErrorMessage = "Mandatory field!")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Category identifier")]
        [Required(ErrorMessage = "Mandatory field!")]
        public int Category_Id { get; set; }

        [DisplayName("Eco-score")]
        [Required(ErrorMessage = "Mandatory field!")]
        [EnumDataType(typeof(EcoScores))]
        public EcoScores EcoScore { get; set; }
    }
}
