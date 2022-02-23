# MoveisCatalog App 

A simple application that displays movies, their description, rating and year of production.

## Display Style: 
After starting the application, the user notices that the application consists of two main pages.

## Home page:
This page contains the cards to display the movies, and every card contains (a picture, a name, a description and a link to the movie information in Wikipedia). 
These cards are not subject to modification, deletion or addition because they are not linked to the database, and the main purpose of creating this page is the necessity of design and personal attention to the fronted development. 

## The second page is Movies:
The idea of this page is to display movies by cards, and these cards are linked to the database through which the user can do the crud system. Every card displays 
(name, picture, description, rating and year of production of the film) by fetching data from a database containing three buttons (edit, details and delete) you can add an endless number of cards that are beside each other.


## Code example:
This class can seeding data to database (MovieCategory table)
```
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
                    new MovieCategory { Category= "Action"},
                    new MovieCategory { Category= "Comedy"},
                    new MovieCategory { Category= "Drama"},
                    new MovieCategory { Category= "Fantasy"},
                    new MovieCategory { Category= "Horror"},
                    new MovieCategory { Category= "Mystery"},
                    new MovieCategory { Category= "Romance"},
                    new MovieCategory { Category= "Thriller"},
                 }); ;
                    context.SaveChanges();
                }}}}}
 
```



## Environment:
C#,asp.net mvc5
html/Css/javascript
Bootstrap
Entity framework core 

## references
[Bootstrap](https://getbootstrap.com/)//
[Microsoft Docs](https://docs.microsoft.com/en-us/)


## Usage:

1: Download .Net SDK 5.0.405
[Download](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

2:Update database.

3: Run App





