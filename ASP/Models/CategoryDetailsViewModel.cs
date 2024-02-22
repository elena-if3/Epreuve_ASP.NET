using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public class CategoryDetailsViewModel
    {
        [DisplayName("Category identifier")]
        public int Cat_Id { get; set; }

        [DisplayName("Category name")]
        public string CatName { get; set; }

        [DisplayName("Category description")]
        public string? CatDescr { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Products in this category")]
        public IEnumerable<ProductListItemViewModel> Products { get; set; }
    }
}
