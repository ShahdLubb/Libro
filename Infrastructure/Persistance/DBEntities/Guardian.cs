namespace Persistance.DBEntities
{
    public class Guardian
    {
        public int GuardianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Patron>? Childs { get; set; }
    }
}
