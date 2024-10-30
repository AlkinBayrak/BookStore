using AutoMapper;
using BookStore.WebApp.Context.Entities.Concrete;
using BookStore.WebApp.Models;

namespace BookStore.WebApp.MapperProfiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<CityViewModel, City>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
                .ReverseMap();
        }
    }
}
