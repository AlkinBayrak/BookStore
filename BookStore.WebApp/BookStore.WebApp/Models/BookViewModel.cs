namespace BookStore.WebApp.Models
{
    public class BookViewModel
    {
        public string Name { get; set; }

        public string BookType { get; set; }

        public string Author { get; set; }
        public short PublishedYear { get; set; }
        public string PublisHouse { get; set; }
        public short PageNumber { get; set; }
        public bool IsPublished { get; set; }

    }
}
