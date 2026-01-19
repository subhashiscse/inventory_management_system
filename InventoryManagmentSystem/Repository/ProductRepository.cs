using InventoryManagmentSystem.Models.Product;

namespace InventoryManagmentSystem.Repository;

public class ProductRepository
{
    private static List<Product> _products = new List<Product>
    {
        new Product
        {
            Id = 1,
            CategoryId = 1,
            Description = "Laptop Desciption",
            Name = "Laptop",
            Price = 100000,
            Quantity = 5,
        },
        new Product
        {
            Id = 2,
            CategoryId = 1,
            Description = "Mouse Desciption",
            Name = "Mouse",
            Price = 500,
            Quantity = 4,
        },
        new Product
        {
            Id = 3,
            CategoryId = 2,
            Description = "Keyboard Desciption",
            Name = "Keyboard",
            Price = 1000,
            Quantity = 10,
        }
    };

    public static List<Product> GetAll()
    {
        return _products;
    }

    public static Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public static void Add(Product product)
    {
        _products.Add(product);
    }

    public static void Update(Product product)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
        //var existingProduct = GetById(product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
        }
    }
    public static void UpdateProductName(Product product)
    {
        var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
        //var existingProduct = GetById(product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
        }
    }

    public static void Delete(int id)
    {
        var existingProduct = GetById(id);
        if (existingProduct != null)
        {
            _products.Remove(existingProduct);
        }
    }
}