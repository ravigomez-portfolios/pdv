using System.ComponentModel.DataAnnotations;

namespace POS.Backend.DTOs{
  public class ProductUpdateDTO{
    [Required]
    [MaxLength(250)]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
  }
}