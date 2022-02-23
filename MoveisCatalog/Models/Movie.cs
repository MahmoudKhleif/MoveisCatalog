using System.ComponentModel.DataAnnotations;
//Movie calss which has id as a primery key and MovieCategoryId as a forigen key 
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
