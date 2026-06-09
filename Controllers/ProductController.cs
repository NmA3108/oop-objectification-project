using Microsoft.AspNetCore.Mvc;
using TestMVC.Models;
using TestMVC.Services;

namespace TestMVC.Controllers;

public class ProductController : Controller
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }

    public IActionResult Index(string? keyword)
    {
        var products = _productService.Search(keyword);

        ViewBag.Keyword = keyword;

        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = _productService.GetById(id);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (!ModelState.IsValid)
        {
            return View(product);
        }

        _productService.Create(product);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var product = _productService.GetById(id);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product product)
    {
        if (!ModelState.IsValid)
        {
            return View(product);
        }

        _productService.Update(product);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var product = _productService.GetById(id);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        _productService.Delete(id);

        return RedirectToAction(nameof(Index));
    }
}
