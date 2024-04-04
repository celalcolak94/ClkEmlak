using AutoMapper;
using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DtoLayer.CategoryDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public async Task TChangeCategoryStatus(int id)
        {
            await _categoryDal.ChangeCategoryStatus(id);
        }

        public async Task TCreateAsync(ResultCategoryDto entity)
        {
            var value = _mapper.Map<Category>(entity);
            await _categoryDal.CreateAsync(value);
        }

        public async Task<List<ResultCategoryDto>> TGetAllAsync()
        {
            var value = await _categoryDal.GetAllAsync();
            return _mapper.Map<List<ResultCategoryDto>>(value);
        }

        public async Task<ResultCategoryDto> TGetByIdAsync(int id)
        {
            var value = await _categoryDal.GetByIdAsync(id);
            return _mapper.Map<ResultCategoryDto>(value);
        }

        public async Task TRemoveAsync(ResultCategoryDto entity)
        {
            var value = _mapper.Map<Category>(entity);
            await _categoryDal.RemoveAsync(value);
        }

        public async Task TUpdateAsync(ResultCategoryDto entity)
        {
            var value = await _categoryDal.GetByIdAsync(entity.CategoryID);
            if (value == null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map(entity, value);
            await _categoryDal.UpdateAsync(value);
        }
    }
}
