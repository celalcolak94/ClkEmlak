using AutoMapper;
using ClkEmlak.DtoLayer.CategoryDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.WebUI.Mapper
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
        }
    }
}
