namespace MovieAPI.Models
{
    public class MovieDB
    {
        public List<Movie> movies { get; set; }
        //private static int nextID = 1;


        public MovieDB()
        {
            movies = new List<Movie>()
            {
                new Movie(0, "SpiderMan", "Action"),
                new Movie(1, "BatMan", "Action"),
                new Movie(2, "Shrek", "Kids"),
                new Movie(3, "Jumanji", "Kids"),
                new Movie(4, "It", "Horror"),
                new Movie(5, "Goosebumps", "Horror")
            };
        }
    }
}
