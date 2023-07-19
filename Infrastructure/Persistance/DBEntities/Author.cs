namespace Persistance.DBEntities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string Biography { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public ICollection<Book>? Books { get; set; }

    }
}
