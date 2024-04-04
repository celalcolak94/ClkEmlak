using AutoMapper;
using ClkEmlak.DtoLayer.ContactDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.WebUI.Mapper
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
        }
    }
}
