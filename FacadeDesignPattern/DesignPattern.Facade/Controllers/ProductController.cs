using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class ProductController : Controller
    {
        Context c = new();
        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            c.Products.Add(product);
            c.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public IActionResult ProductList()
        {
            var values = c.Products.ToList();
            return View(values);
        }
    }
}
