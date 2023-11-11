namespace API.Models;

public class Category : BaseModel
{
    public string Name { get; set; }
    
    public int DisplayOrder { get; set; }
}