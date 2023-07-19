namespace Persistance.DBEntities
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int ItemId { get; set; }
        public int PatronId { get; set; }
        public int LibrarianId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }

        public Item Item { get; set; }
        public Patron Patron { get; set; }
        public Librarian Librarian { get; set; }
    }
}
