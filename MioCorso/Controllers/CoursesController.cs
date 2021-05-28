using Microsoft.AspNetCore.Mvc;



namespace MioCorso.Controllers
{
    public class CoursesController:Controller
    {
       
     public IActionResult Index()
     {
         return View();       
     }   
     
     public IActionResult Details(string id)
     {
         return View();               // ritorna l id di uno specifico corso cercato
     }

        public IActionResult Search(string title)
        {
           return Content($"Hai cercato {title}");
        }
    }
}