namespace Persistance.DBEntities
{
    public class ReadingList
    {
        public int ReadingListId { get; set; }
        public int PatronId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Privacy { get; set; }

        public Patron Patron { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
