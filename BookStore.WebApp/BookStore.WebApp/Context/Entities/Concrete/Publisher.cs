using BookStore.WebApp.Context.Entities.Abstract;

namespace BookStore.WebApp.Context.Entities.Concrete
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
