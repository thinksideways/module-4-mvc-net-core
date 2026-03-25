using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CustomerController(DataContext db) : Controller
    {
        private readonly DataContext _dataContext = db;

        public ActionResult Index()
        {
            var customers = _dataContext.Customers.OrderBy(c => c.CompanyName);
            // var customers = _dataContext.Customers.Where(c => !c.CompanyName.Equals(null)).OrderBy(c => c.CompanyName);
            return View(customers);
        }
        
        [HttpGet]
        public IActionResult Register()
        {
            return View(new Customer());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                if (_dataContext.Customers.Any(b => b.CompanyName == model.CompanyName))
                {
                    ModelState.AddModelError("", "Name must be unique");
                    return View();
                }
                else
                {
                    _dataContext.AddCustomer(model);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View();
            }
        }
    }
}