using AutoMapper;
using ClkEmlak.DtoLayer.ImageDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.WebUI.Mapper
{
    public class ImageMapping : Profile
    {
        public ImageMapping()
        {
            CreateMap<Image, ResultImageDto>().ReverseMap();
        }
    }
}
