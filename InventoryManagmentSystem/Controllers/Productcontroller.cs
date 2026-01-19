using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Models.Product;
using InventoryManagmentSystem.Repository;

namespace InventoryManagmentSystem.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var products = ProductRepository.GetAll();
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = ProductRepository.GetById(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        ProductRepository.Add(product);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}