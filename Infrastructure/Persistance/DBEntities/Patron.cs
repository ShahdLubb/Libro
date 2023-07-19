namespace Persistance.DBEntities
{
    public class Patron
    {
        public int PatronId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guardian? ChildGuardian { get; set; }

        public ICollection<Review>? BookReviews { get; set; }
        public ICollection<ReadingList>? ReadingLists { get; set; }
        public ICollection<Borrow>? Borrowings { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
