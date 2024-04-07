using System.Text.Json.Serialization;

namespace DiziSinema.MVC.Areas.Admin.Models.Movie
{
    public class DeletedMovieViewModel
    {
        public int Id { get; set; }


        public string MovName { get; set; }


        public string Movlanguage { get; set; }


        public bool IsDeleted { get; set; }


        public DateTime CreatedDate { get; set; }


        public DateTime ModifiedDate { get; set; }
    }
}
