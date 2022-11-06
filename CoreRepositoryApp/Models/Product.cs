using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRepositoryApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage ="Please Provide your Product name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Provide your Product Description")]
        [Display(Name ="Product Description")]
        public string Description { get; set; }
        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "Please Provide your Product Price")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

    }
}
