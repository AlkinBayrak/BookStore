namespace BookStore.WebApp.Models
{
    public class AuthorViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Cityname { get; set; }
        public bool IsActive { get; set; }

    }
}
