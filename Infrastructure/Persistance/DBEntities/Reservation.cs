namespace Persistance.DBEntities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BookId { get; set; }
        public int PatronId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string State { get; set; }

        public Book Book { get; set; }
        public Patron Patron { get; set; }
    }
}
