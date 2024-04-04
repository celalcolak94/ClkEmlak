using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.EntityFramework;
using ClkEmlak.DtoLayer.MessageDtos;
using ClkEmlak.DtoLayer.SocialMediaDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        private readonly IMapper _mapper;

        public SocialMediaManager(ISocialMediaDal socialMediaDal, IMapper mapper)
        {
            _socialMediaDal = socialMediaDal;
            _mapper = mapper;
        }

        public async Task TCreateAsync(ResultSocialMediaDto entity)
        {
            var value = _mapper.Map<SocialMedia>(entity);
            await _socialMediaDal.CreateAsync(value);
        }

        public async Task<List<ResultSocialMediaDto>> TGetAllAsync()
        {
            var value = await _socialMediaDal.GetAllAsync();
            return _mapper.Map<List<ResultSocialMediaDto>>(value);
        }

        public async Task<ResultSocialMediaDto> TGetByIdAsync(int id)
        {
            var value = await _socialMediaDal.GetByIdAsync(id);
            return _mapper.Map<ResultSocialMediaDto>(value);
        }

        public async Task TRemoveAsync(ResultSocialMediaDto entity)
        {
            var value = _mapper.Map<SocialMedia>(entity);
            await _socialMediaDal.RemoveAsync(value);
        }

        public async Task TUpdateAsync(ResultSocialMediaDto entity)
        {
            var value = await _socialMediaDal.GetByIdAsync(entity.SocialMediaID);
            if (value == null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map(entity, value);
            await _socialMediaDal.UpdateAsync(value);
        }
    }
}
