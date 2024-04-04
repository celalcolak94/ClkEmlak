using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DtoLayer.MessageDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        private readonly IMapper _mapper;

        public MessageManager(IMessageDal messageDal, IMapper mapper)
        {
            _messageDal = messageDal;
            _mapper = mapper;
        }

        public Task<int> TComingMessageCount()
        {
            return _messageDal.ComingMessageCount();
        }

        public async Task TCreateAsync(ResultMessageDto entity)
        {
            var value = _mapper.Map<Message>(entity);
            await _messageDal.CreateAsync(value);
        }

        public async Task<List<ResultMessageDto>> TGetAllAsync()
        {
            var value = await _messageDal.GetAllAsync();
            return _mapper.Map<List<ResultMessageDto>>(value);
        }

        public async Task<ResultMessageDto> TGetByIdAsync(int id)
        {
            var value = await _messageDal.GetByIdAsync(id);
            return _mapper.Map<ResultMessageDto>(value);
        }

        public async Task TRemoveAsync(ResultMessageDto entity)
        {
            var value = _mapper.Map<Message>(entity);
            await _messageDal.RemoveAsync(value);
        }

        public async Task TUpdateAsync(ResultMessageDto entity)
        {
            var value = await _messageDal.GetByIdAsync(entity.MessageID);
            if (value == null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map(entity, value);
            await _messageDal.UpdateAsync(value);
        }
    }
}
