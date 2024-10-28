using AutoMapper;
using BookStore.WebApp.Context;
using BookStore.WebApp.Context.Entities.Concrete;
using BookStore.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.WebApp.Controllers
{
	public class CityController : Controller
	{
        //private readonly IConfiguration _configuration;
        //public CityController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        private readonly BookStoreDbContext _dbContext;
        private MapperConfiguration _mapCongif;
		private IMapper _mapper;

        public CityController(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;

            _mapCongif = new MapperConfiguration(
                cfg=>cfg.CreateMap<CityViewModel,City>()
                .ForMember(dest=>dest.IsActive,opt => opt.MapFrom(src=>src.Status))
                .ReverseMap());
            _mapper = new Mapper(_mapCongif);
        }

        public IActionResult Index()
		{
			List<City> cities = _dbContext.Cities.Where(c=>c.IsDeleted == false).ToList();

            List<CityViewModel> model = _mapper.Map<List<CityViewModel>>(cities);

			return View(model);
		}

        public IActionResult New()
        {
			CityViewModel model = new CityViewModel();

           

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CityViewModel model)
        {
			//DbContextOptionsBuilder dbContextOptionBuilder = new DbContextOptionsBuilder<BookStoreDbContext>();
   //         dbContextOptionBuilder.UseSqlServer("Server=VMI1229542;Database=BookStoreDb;Trusted_Connection=true;Trustservercertificate=true");

   //         DbContextOptions dbContextOptions = dbContextOptionBuilder.Options;

   //         BookStoreDbContext bookStoreDbContext = new BookStoreDbContext(dbContextOptions);

            City city = _mapper.Map<City>(model);

            _dbContext.Cities.Add(city);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
           City city = _dbContext.Cities.Where(c => c.Id == id).FirstOrDefault();

            CityViewModel model = _mapper.Map<CityViewModel>(city);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CityViewModel model)
        {   

            City city = _mapper.Map<City>(model);

            _dbContext.Cities.Update(city);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

       
        public IActionResult Remove(int id)
        {
            City city = _dbContext.Cities.Where(c => c.Id == id).FirstOrDefault();

            if(city == null)
            {
                city.IsDeleted = true;
                city.Deleted = DateTime.Now;

                _dbContext.Cities.Update(city);
                _dbContext.SaveChanges();
            }
            

            return RedirectToAction(nameof(Index));
        }
    }
}
