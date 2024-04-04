using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DtoLayer.EstateDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Concrete
{
    public class EstateManager : IEstateService
    {
        private readonly IEstateDal _estateDal;
        private readonly IMapper _mapper;

        public EstateManager(IEstateDal estateDal, IMapper mapper)
        {
            _estateDal = estateDal;
            _mapper = mapper;
        }

		public async Task TCreateAsync(ResultEstateDto entity)
        {
            var value = _mapper.Map<Estate>(entity);
            await _estateDal.CreateAsync(value);
        }

		public async Task<int> TEstateCountByForRent()
        {
            return await _estateDal.EstateCountByForRent();
        }

        public async Task<int> TEstateCountByForSale()
		{
			return await _estateDal.EstateCountByForSale();
		}

		public async Task<List<EstateWithCategoryDto>> TEstateListByForRent()
        {
            var value = await _estateDal.EstateListByForRent();
            return _mapper.Map<List<EstateWithCategoryDto>>(value);
        }

        public async Task<List<EstateWithCategoryDto>> TEstateListByForSale()
        {
            var value = await _estateDal.EstateListByForSale();
            return _mapper.Map<List<EstateWithCategoryDto>>(value);
        }

        public async Task<List<EstateWithCategoryDto>> TEstateListByHomePage()
        {
            var value = await _estateDal.EstateListByHomePage();
            return _mapper.Map<List<EstateWithCategoryDto>>(value);
        }

        public async Task<List<EstateWithCategoryDto>> TEstateListByStatusTrue()
        {
            var value = await _estateDal.EstateListByStatusTrue();
            return _mapper.Map<List<EstateWithCategoryDto>>(value);
        }

		public async Task<List<ResultEstateDto>> TGetAllAsync()
        {
            var value = await _estateDal.GetAllAsync();
            return _mapper.Map<List<ResultEstateDto>>(value);
        }

        public async Task<ResultEstateDto> TGetByIdAsync(int id)
        {
            var value = await _estateDal.GetByIdAsync(id);
            return _mapper.Map<ResultEstateDto>(value);
        }

		public async Task<ResultEstateDto> TGetByIdEstateWithImage(int id)
		{
            var value = await _estateDal.GetByIdEstateWithImage(id);
            return _mapper.Map<ResultEstateDto>(value);
		}

		public async Task TRemoveAsync(ResultEstateDto entity)
        {
            var value = _mapper.Map<Estate>(entity);
            await _estateDal.RemoveAsync(value);
        }

        public async Task TUpdateAsync(ResultEstateDto entity)
        {
            var value = await _estateDal.GetByIdAsync(entity.EstateID);

            if (value == null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map(entity, value);
            await _estateDal.UpdateAsync(value);
        }
    }
}
