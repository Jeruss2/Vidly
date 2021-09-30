namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreTypeId) VALUES('Hangover', '06-02-2009', GetDate(), 5, 2)");
            Sql("INSERT INTO dbo.Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreTypeId) VALUES('Die Hard', '07-22-1988', GetDate(), 5, 1)");
            Sql("INSERT INTO dbo.Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreTypeId) VALUES('The Terminator', '10-26-1984', GetDate(), 5, 1)");
            Sql("INSERT INTO dbo.Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreTypeId) VALUES('Toy Story', '11-22-1995', GetDate(), 5, 4)");
            Sql("INSERT INTO dbo.Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreTypeId) VALUES('Titantic', '12-19-1997', GetDate(), 5, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
