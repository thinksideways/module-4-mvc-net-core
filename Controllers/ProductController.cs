using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class ProductController(DataContext db) : Controller
{
    // this controller depends on the DataContext
    private readonly DataContext _dataContext = db;
    public IActionResult Category() => View(_dataContext.Category.OrderBy(c => c.CategoryName));
}