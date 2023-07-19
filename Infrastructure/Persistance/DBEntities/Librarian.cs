﻿namespace Persistance.DBEntities
{
    public class Librarian
    {
        public int LibrarianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Borrow>? Checkouts { get; set; }
        public ICollection<CheckIn>? CheckIns { get; set; }
    }

}
