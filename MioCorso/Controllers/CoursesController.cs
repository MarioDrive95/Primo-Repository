using Microsoft.AspNetCore.Mvc;
using MioCorso.Models.Services;
using MioCorso.Models.ViewModels;
using MyCourse.Models.ViewModels;
using System.Collections.Generic;

namespace MioCorso.Controllers
{
    public class CoursesController:Controller
    {
       
     public IActionResult Index()
     {
         CoursesService cservices = new CoursesService();
         List<CoursesViewModel> elencocourses = cservices.GetCourses();
         return View(elencocourses);       
     }   
     
     public IActionResult Details(int id)
     {
                 
           var courseService = new CoursesService();
            CoursesDetailsViewModel detailcourse = courseService.GetCourse(id);           
            return View(detailcourse);           // ritorna l id di uno specifico corso cercato
     }

        public IActionResult Search(string title)
        {
           return Content($"Hai cercato {title}");
        }
    }
}