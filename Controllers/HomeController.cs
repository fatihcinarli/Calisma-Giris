using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApp.Models;

namespace FormApp.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index(string searchString)
    {
        return View(Repository.GetProducts);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
