namespace Persistance.DBEntities
{
    public class Book
    {
        public int BookId { get; set; }
        public string CallNumber { get; set; }
        public string Title { get; set; }
        public string GenreCode { get; set; }
        public int Edition { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
        public string City { get; set; }
        public DateTime PublishYear { get; set; }
        public string Collation { get; set; }

        public Genre Genre { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Keyword> Keywords { get; set; }
        public ICollection<Review>? BookReviews { get; set; }
        public ICollection<ReadingList>? ReadingLists { get; set; }

    }

}
