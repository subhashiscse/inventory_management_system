using System.ComponentModel.DataAnnotations;
using InventoryManagmentSystem.Models.Product;

public class Supplier
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Country { get; set; }
    public string? ContactInfo { get; set; }

    public ICollection<Product>? Products { get; set; }
}