using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class ProductController(DataContext db) : Controller
{
    private readonly DataContext _dataContext = db;
    public IActionResult Category() => View(_dataContext.Category.OrderBy(c => c.CategoryName));

    public IActionResult Index(int categoryId)
    {
        var products = _dataContext.Products.Where(product => product.CategoryId.Equals(categoryId)).Where(product => product.Discontinued.Equals(false));
        return View(products);
    }
}