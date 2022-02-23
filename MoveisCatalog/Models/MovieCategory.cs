using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveisCatalog.Models
{
    //MovieCategory which has id as a forigen key
    public class MovieCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
