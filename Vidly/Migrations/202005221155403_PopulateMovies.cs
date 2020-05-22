namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Mission Impossible', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Star Wars', 1)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES  ('Toy Story', 3)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Titanic',4)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Spider-Man: Into the Spider-Verse',3)");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Kung Fu Panda',5)");
        }
        
        public override void Down()
        {
        }
    }
}
