namespace Persistance.DBEntities
{
    public class Genre
    {
        public string GenreCode { get; set; }
        public string GenreValue { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
