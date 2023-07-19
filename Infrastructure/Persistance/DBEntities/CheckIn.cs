namespace Persistance.DBEntities
{
    public class CheckIn
    {
        public int CheckInId { get; set; }
        public int BorrowingId { get; set; }
        public int LibrarianId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int OverdueCharge { get; set; }

        public Borrow Borrowing { get; set; }
        public Librarian Librarian { get; set; }
    }
}
