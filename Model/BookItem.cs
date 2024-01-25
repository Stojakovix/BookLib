using SQLite;


namespace BookLib.Model
{
    public class BookItem
    {
        [AutoIncrement, Unique, Column("Id")]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float Rating { get; set; }
        public string? Description { get; set; }
        

    }
}
