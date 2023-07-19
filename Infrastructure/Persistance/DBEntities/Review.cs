namespace Persistance.DBEntities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int BookId { get; set; }
        public int PatronId { get; set; }
        public decimal Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public Book Book { get; set; }
        public Patron Patron { get; set; }
    }
}
