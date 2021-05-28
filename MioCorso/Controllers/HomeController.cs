
using Microsoft.AspNetCore.Mvc;

namespace MioCorso.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
       {
           return View();
       } 

       public IActionResult Details(string id)
       {
           return Content($"Sono l id default {id}");
       }
    }
}