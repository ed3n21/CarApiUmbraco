using AutoMapper;
using CarApi.Models;
using Umbraco.Core.Models.PublishedContent;

namespace CarApi.App_Start
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarBrand, CarBrandViewModel>()
                .ForMember(dest => dest.Icon, opt => opt.MapFrom(src => src.Icon.Url))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.ToString()))
                /*.ForMember(dest => dest.FoundationDate)*/;
            CreateMap<CarModel, CarViewModel>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image.Url))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.ToString()))
                /*.ForMember(dest => dest.FoundationDate)*/;
        }
    }
}