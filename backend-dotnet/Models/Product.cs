using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Backend.Models{
  public class Product : BaseEntity{
    
    [Required]
    [MaxLength(250)]
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
  }
}