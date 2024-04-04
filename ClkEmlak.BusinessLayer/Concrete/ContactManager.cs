using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DtoLayer.ContactDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        private readonly IMapper _mapper;

        public ContactManager(IContactDal contactDal, IMapper mapper)
        {
            _contactDal = contactDal;
            _mapper = mapper;
        }

        public async Task TCreateAsync(ResultContactDto entity)
        {
            var value = _mapper.Map<Contact>(entity);
            await _contactDal.CreateAsync(value);
        }

        public async Task<List<ResultContactDto>> TGetAllAsync()
        {
            var value = await _contactDal.GetAllAsync();
            return _mapper.Map<List<ResultContactDto>>(value);
        }

        public async Task<ResultContactDto> TGetByIdAsync(int id)
        {
            var value = await _contactDal.GetByIdAsync(id);
            return _mapper.Map<ResultContactDto>(value);
        }

        public async Task TRemoveAsync(ResultContactDto entity)
        {
            var value = _mapper.Map<Contact>(entity);
            await _contactDal.RemoveAsync(value);
        }

        public async Task TUpdateAsync(ResultContactDto entity)
        {
            var value = await _contactDal.GetByIdAsync(entity.ContactID);
            if (value == null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map(entity, value);
            await _contactDal.UpdateAsync(value);
        }
    }
}
