using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Eshop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 1000, ErrorMessage = "Display order should be between 1-1000.")]
        public int DisplayOrder { get; set; }
    }
}
