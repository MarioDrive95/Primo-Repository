using Microsoft.AspNetCore.Mvc;



namespace MioCorso.Controllers
{
    public class CoursesController:Controller
    {
       
     public IActionResult Index()
     {
         return Content("Sono Index");       
     }   
     
     public IActionResult Details(string id)
     {
         return Content($"Sono{id}");               // ritorna l id di uno specifico corso cercato
     }
        
    }
}