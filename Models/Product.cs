using System.ComponentModel.DataAnnotations;

namespace FunctionalApi;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "{0} field is mandatory")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "{0} field is mandatory")]
    [Range(1, int.MaxValue, ErrorMessage = "{0} value must be greater than 0")]
    public decimal Price { get; set; }
    [Required(ErrorMessage = "{0} field is mandatory")]
    public int QuantityInStock { get; set; }
    [Required(ErrorMessage = "{0} field is mandatory")]
    public string? Description { get; set; }
}
