using System;
using System.Collections.Generic;
using System.Linq;
using MioCorso.Models.ViewModels;
using MyCourse.Models.ValueTypes;

namespace MyCourse.Models.ViewModels
{
    public class CoursesDetailsViewModel : CoursesViewModel
    {
        public string Description { get; set; }
        public List<LessonViewModel> Lessons { get; set; }

        public TimeSpan TotalCourseDuration
        {
            get => TimeSpan.FromSeconds(Lessons?.Sum(l => l.Duration.TotalSeconds) ?? 0);
        }
    }
}