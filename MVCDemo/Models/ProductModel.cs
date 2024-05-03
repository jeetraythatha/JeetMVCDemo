using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }

        public List<CategoryModel> categories { get; set; }
    }
}
