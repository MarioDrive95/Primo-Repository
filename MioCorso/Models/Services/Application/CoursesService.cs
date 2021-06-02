using System;
using System.Collections.Generic;
using MioCorso.Models.ViewModels;
using MyCourse.Models.Enums;
using MyCourse.Models.ValueTypes;
using MyCourse.Models.ViewModels;

namespace MioCorso.Models.Services
{
    public class CoursesService
    {
        internal List<CoursesViewModel> GetCourses()
        {
            var courseList = new List<CoursesViewModel>();
            var rand = new Random();
            for (int i = 1; i <= 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CoursesViewModel
                {
                    Id = i,
                    Title = $"Corso {i}",
                    CurrentPrice = new Money(Currency.EUR, price),
                    FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price + 1),
                    Author = "Nome cognome",
                    Rating = rand.Next(10, 50) / 10.0,
                    ImagePath = "/manubrio.svg"
                };
                courseList.Add(course);
            }
            return courseList;
        }

         public CoursesDetailsViewModel GetCourse(int id)
        {
            var rand = new Random();
            var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            var course = new CoursesDetailsViewModel
            {
                Id = id,
                Title = $"Corso {id}",
                CurrentPrice = new Money(Currency.EUR, price),
                FullPrice = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price + 1),
                Author = "Nome cognome",
                Rating = rand.Next(10, 50) / 10.0,
                ImagePath = "/manubrio.svg",
                Description = $"Descrizione {id}",
                Lessons = new List<LessonViewModel>()
            };

            for (var i = 1; i <= 5; i++) {
                var lesson = new LessonViewModel {
                    Title = $"Lezione {i}",
                    Duration = TimeSpan.FromSeconds(rand.Next(40, 90))
                };
                course.Lessons.Add(lesson);
            }

            return course;
        }
    }
}