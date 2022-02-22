using System.ComponentModel.DataAnnotations;

namespace MoveisCatalog.Models
{
    public class Movie
    {   [Key]
        public  int id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [ Required,Display(Name = "Category")]
        public int MovieCategoryId { get; set; }
        public  MovieCategory MovieCategory { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string Rate { get; set; }


    }
}
