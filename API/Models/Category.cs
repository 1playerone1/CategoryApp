using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Category : BaseModel
{
    [Required]
    [DisplayName("Category Name")]
    public string Name { get; set; }
    
    [Required]
    [DisplayName("Display Order")]
    [Range(1, 100)]
    public int DisplayOrder { get; set; }
}