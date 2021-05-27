
using Microsoft.AspNetCore.Mvc;

namespace MioCorso.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
       {
           return Content("Sono Index Default della Home");
       } 

       public IActionResult Details(string id)
       {
           return Content($"Sono l id default {id}");
       }
    }
}