using AutoMapper;
using BookStore.WebApp.Context;
using BookStore.WebApp.Context.Entities.Concrete;
using BookStore.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.WebApp.Controllers
{
	public class PublisherController : Controller
	{
        private readonly BookStoreDbContext _dbContext;
        private IMapper _mapper;

        public PublisherController(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IActionResult Index()
		{
            List<Publisher> publishers = _dbContext.Publishers.Include(p=>p.City).ToList();

            List<PublisherViewModel> model = _mapper.Map<List<PublisherViewModel>>(publishers);

            return View(model);
        }

		[HttpGet]
        public IActionResult Add()
        {
			PublisherViewModel model = new PublisherViewModel();

            List<City> cities = _dbContext.Cities.ToList();

            List<CityViewModel> cityList = _mapper.Map<List<CityViewModel>>(cities);

            ViewBag.CityList = cityList;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(PublisherViewModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            Publisher publisher = _mapper.Map<Publisher>(model);

            _dbContext.Publishers.Add(publisher);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}
