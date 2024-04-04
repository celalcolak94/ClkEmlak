using AutoMapper;
using ClkEmlak.DtoLayer.SocialMediaDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.WebUI.Mapper
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
        }
    }
}
