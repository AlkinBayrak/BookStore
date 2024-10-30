using BookStore.WebApp.Context.Entities.Abstract;

namespace BookStore.WebApp.Context.Entities.Concrete
{
	public class City : BaseEntity
	{
        public string Name { get; set; }

        public virtual ICollection<Publisher> Publishers { get; set; }
    }
}
