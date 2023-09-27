using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class CustomerController : Controller
    {
        Context c = new();
        [HttpGet]
        public IActionResult AddNewCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            c.Customers.Add(customer);
            c.SaveChanges();
            return RedirectToAction("CustomerList");
        }
        public IActionResult CustomerList()
        {
            var values = c.Customers.ToList();
            return View(values);
        }
    }
}
