using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MoveisCatalog.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoveisCatalog.Data
{     //Seedin data to MovieCategories table
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppicationDbcontext>();

                context.Database.EnsureCreated();

                //MovieCategory
                if (!context.MovieCategories.Any())
                {
                    context.MovieCategories.AddRange(new List<MovieCategory>()
                    {
                    new MovieCategory
                    {  
                        Category= "Action"
                    },
                    new MovieCategory
                    {   
                        Category= "Comedy"
                    },
                    new MovieCategory
                    {   
                        Category= "Drama"
                    },
                    new MovieCategory
                    {   
                        Category= "Fantasy"
                    },
                    new MovieCategory
                    {  
                        Category= "Horror"
                    },
                    new MovieCategory
                    {   
                        Category= "Mystery"
                    },
                    new MovieCategory
                    {   
                        Category= "Romance"
                    },
                    new MovieCategory
                    {   
                        Category= "Thriller"
                    },

                    }); ;
                    context.SaveChanges();
                }
            }
        }
    }
}

