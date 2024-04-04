using ClkEmlak.DtoLayer.MessageDtos;

namespace ClkEmlak.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<ResultMessageDto>
    {
        Task<int> TComingMessageCount();
    }
}
