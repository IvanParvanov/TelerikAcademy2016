namespace RememBeer.Data
{
    using System.Data.Entity;

    using Models;

    public class RememBeerMeDbContext : DbContext
    {
        // Your context has been configured to use a 'RememBeerMeDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RememBeer.Data.RememBeerMeDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RememBeerMeDbContext' 
        // connection string in the application configuration file.
        public RememBeerMeDbContext()
            : base("name=RememBeerMeDbContext")
        {
            this.Database.CreateIfNotExists();
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual IDbSet<Beer> Beers { get; set; }

        public virtual IDbSet<BeerReview> BeerReviews { get; set; }

        public virtual IDbSet<BeerType> BeerTypes { get; set; }

        public virtual IDbSet<Brewery> Breweries { get; set; }
    }
}