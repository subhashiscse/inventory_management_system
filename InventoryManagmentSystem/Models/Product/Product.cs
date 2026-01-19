using System.ComponentModel.DataAnnotations;

namespace InventoryManagmentSystem.Models.Product;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Product name is required")]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Category is required")]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Supplier is required")]
    public int SupplierId { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
    public int Quantity { get; set; }

    // Navigation properties (optional but recommended for EF Core)
    public Category? Category { get; set; }
    public Supplier? Supplier { get; set; }
}