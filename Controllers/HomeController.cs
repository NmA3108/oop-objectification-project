using Microsoft.AspNetCore.Mvc;
using TestMVC.Services;

namespace TestMVC.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public IActionResult Index()
    {
        var products = _productService.GetAll().Take(3).ToList();

        return View(products);
    }
}
