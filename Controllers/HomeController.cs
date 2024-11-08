using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers;

public class HomeController : Controller
{
    

    public HomeController()
    {
       
    }

    public IActionResult Index(string searchString , string category)
    {
        var products = Repository.Products;

        if(! string.IsNullOrEmpty(searchString) ) 
        {
            ViewBag.searchString=searchString;
            products= products.Where(p=>p.Name.ToLower().Contains(searchString)).ToList();
        }

        if(! string.IsNullOrEmpty(category) && category != "0" ) 
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

        // ViewBag.Categories = new SelectList(Repository.Categories , "CategoryId" , "Name" , category);

        var model = new ProductViewModel {
            Products = products ,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories=  new SelectList(Repository.Categories , "CategoryId" , "Name" );
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product model)
    {
        return View();
    }


}
