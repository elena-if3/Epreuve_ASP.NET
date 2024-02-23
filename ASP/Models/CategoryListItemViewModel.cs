using System.ComponentModel;

namespace ASP.Models
{
    public class CategoryListItemViewModel
    {
        [DisplayName("Category identifier")]
        public int Cat_Id { get; set; }

        [DisplayName("Category name")]
        public string CatName { get; set; }

        //[DisplayName("Category description")]
        //public string? CatDescr { get; set; }
    }
}
