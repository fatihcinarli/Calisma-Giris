using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormApp.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index(string searchString, String category)
    {
        var products = Repository.GetProducts;
        if(!String.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }
        if(!String.IsNullOrEmpty(category))
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }
        ViewBag.Categories = new SelectList(Repository.GetCategories, "CategoryId", "CategoryName");
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
