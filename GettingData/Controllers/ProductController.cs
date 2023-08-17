using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product() {ID=1, ProductName = "Book", CategoryName = "Stationery"},
            new Product() {ID=2, ProductName = "Phone", CategoryName = "Electronic"},
            new Product() {ID=3, ProductName = "Tablet", CategoryName = "Electronic"},
            new Product() {ID=4, ProductName = "Eraser", CategoryName = "Stationery"},
        };

        public IActionResult GetAllProduct()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.ID == id);

            if (product == null)
                ViewBag.Error = "The given id is not match!";
            return View(product);
        }

        public IActionResult GetProductByCategory(string categoryname)
        {
            List<Product> products2 = products.FindAll(products => products.CategoryName == categoryname);

            if (products2.Count == 0)
                ViewBag.Error2 = "The given categoryname is not match!";
            return View(products2);
        }

        public IActionResult GetProductsByCategoryName(string categoryname)
        {
            List<Product> p = products.FindAll(x => x.CategoryName == categoryname);

            if (p.Count == 0)
                ViewData["Error"] = "No data found in the requested category.";
            return View(p);
        }

        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return View("GetAllProduct",products);
        }
    }
}
