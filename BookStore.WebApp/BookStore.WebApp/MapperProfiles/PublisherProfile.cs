using AutoMapper;
using BookStore.WebApp.Context.Entities.Concrete;
using BookStore.WebApp.Models;

namespace BookStore.WebApp.MapperProfiles
{
    public class PublisherProfile : Profile
    {

        public PublisherProfile()
        {
            CreateMap<Publisher,PublisherViewModel>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.CityName,opt => opt.MapFrom(src => src.City.Name));

            CreateMap<PublisherViewModel, Publisher>()
               .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status));
               
        }
    }
}
