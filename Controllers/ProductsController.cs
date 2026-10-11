using Microsoft.AspNetCore.Mvc;
using Practical_6_Product_Catalog.Models;

namespace Practical_6_Product_Catalog.Controllers
{
    public class ProductsController : Controller
    {
        // Sample in-memory product data for this practical.
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 650.00m, Description = "Portable computer for study and work.", ImageFile = "laptop.jpg" },
            new Product { Id = 2, Name = "Headphones", Category = "Accessories", Price = 35.50m, Description = "Comfortable headphones for music and calls.", ImageFile = "headphones.jpg" },
            new Product { Id = 3, Name = "Smartphone", Category = "Electronics", Price = 420.00m, Description = "Smart device for communication and apps.", ImageFile = "smartphone.jpg" },
            new Product { Id = 4, Name = "Backpack", Category = "Stationery", Price = 28.99m, Description = "Everyday backpack for books and equipment.", ImageFile = "backpack.jpg" }
        };

        public IActionResult Index()
        {
            return View(Products);
        }

        public IActionResult Details(int id)
        {
            Product? product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
