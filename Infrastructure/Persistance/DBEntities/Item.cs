namespace Persistance.DBEntities
{
    public class Item
    {
        public int ItemId { get; set; }
        public int BookId { get; set; }
        public string State { get; set; }

        public Book Book { get; set; }
    }
}
