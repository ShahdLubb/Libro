namespace Persistance.DBEntities
{
    public class Keyword
    {
        public int KeywordId { get; set; }
        public string KeywordName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
