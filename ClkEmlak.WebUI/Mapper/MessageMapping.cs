using AutoMapper;
using ClkEmlak.DtoLayer.MessageDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.WebUI.Mapper
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<Message, ResultMessageDto>().ReverseMap();
        }
    }
}
