using Microsoft.EntityFrameworkCore;
using MoveisCatalog.Models;
//Dbcontext
namespace MoveisCatalog.Data
{   
    public class AppicationDbcontext :DbContext
    {

        public AppicationDbcontext(DbContextOptions<AppicationDbcontext> options) : base(options)

        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
     
    }
}
