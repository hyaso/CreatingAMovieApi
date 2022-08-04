namespace CreatingAMovieApi.Models
{
    public class MovieDB
    {
        public List<Movie> Movies { get; set; }

        public MovieDB()
        {
            Movies = new List<Movie>()
            {
                new Movie(0, "Harry Potter", "Fantasy"),
                new Movie(1, "Lord of the Rings", "Fantasy"),
                new Movie(2, "Iron Man", "Action"),
                new Movie(3, "Jurassic Park", "Action"),
                new Movie(4, "The Departed", "Drama"),
                new Movie(5, "Braveheart", "Drama"),
                new Movie(6, "Knives Out", "Mystery"),
                new Movie(7, "Prisoners", "Mystery")
            };
        }
    }
}
