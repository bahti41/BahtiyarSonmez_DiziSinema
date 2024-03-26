using System.Text.Json.Serialization;

namespace DiziSinema.MVC.Areas.Admin.Models
{
    public class MovieViewModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("MovName")]
        public string MovName { get; set; }

        [JsonPropertyName("MovIntro")]
        public string MovIntro { get; set; }

        [JsonPropertyName("Movlanguage")]
        public string Movlanguage { get; set; }

        [JsonPropertyName("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }
    }
}
