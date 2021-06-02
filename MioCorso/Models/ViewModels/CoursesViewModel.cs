using MyCourse.Models.ValueTypes;

namespace MioCorso.Models.ViewModels
{
    public class CoursesViewModel
    {
      public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }  // valore decimale per VOTO il cui sara associato a stelle
        public Money FullPrice { get; set; }
        public Money CurrentPrice { get; set; }      
    }
}