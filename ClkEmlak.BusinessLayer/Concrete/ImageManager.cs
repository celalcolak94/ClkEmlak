using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DtoLayer.ImageDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;
        private readonly IMapper _mapper;

        public ImageManager(IImageDal imageDal, IMapper mapper)
        {
            _imageDal = imageDal;
            _mapper = mapper;
        }

        public async Task TCreateAsync(ResultImageDto entity)
        {
            var value = _mapper.Map<Image>(entity);
            await _imageDal.CreateAsync(value);
        }

        public Task<List<ResultImageDto>> TGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultImageDto> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultImageDto>> TImageListByEstate(int id)
        {
            var value = await _imageDal.ImageListByEstate(id);
            return _mapper.Map<List<ResultImageDto>>(value);
        }

        public Task TRemoveAsync(ResultImageDto entity)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(ResultImageDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
