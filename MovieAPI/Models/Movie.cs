namespace MovieAPI.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        
        public Movie(int newId, string newTitle, string newCategory)
        {
            this.ID = newId;
            this.Title = newTitle;
            this.Category = newCategory;
        }
    }
}
