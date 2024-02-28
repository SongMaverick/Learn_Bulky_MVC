using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Learn_BulkyWeb.Models; 

public class Category {
    
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public int DisplayOrder { get; set; }
}