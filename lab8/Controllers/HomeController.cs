using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab8.Models;

namespace lab8.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Product> products = new List<Product>
        {
            new Product(1, "Product 1", 10.99, DateTime.Now),
            new Product(2, "Product 2", 19.99, DateTime.Now),
            new Product(3, "Product 3", 5.99, DateTime.Now)
        };

        return View(products);
    }
}