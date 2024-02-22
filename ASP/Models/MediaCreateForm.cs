using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public class MediaCreateForm
    {
        [DisplayName("Photo to upload")]
        [Required(ErrorMessage = "Mandatory field!")]
        public IFormFile Photo { get; set; }

        [DisplayName("Product identifier")]
        [Required(ErrorMessage = "Mandatory field!")]
        public int Product_Id { get; set; }
    }
}
