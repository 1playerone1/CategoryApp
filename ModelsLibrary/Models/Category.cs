using System.ComponentModel;

namespace ModelsLibrary.Models;

public class Category : BaseModel
{
    [DisplayName("Category Name")]
    public string Name { get; set; }
    
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }
}