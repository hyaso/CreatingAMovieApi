namespace CreatingAMovieApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(int _id, string _title, string _category)
        {
            Id = _id;
            Title = _title;
            Category = _category;
        }
    }
}
