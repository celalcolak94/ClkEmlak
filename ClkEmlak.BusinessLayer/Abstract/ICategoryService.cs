using ClkEmlak.DtoLayer.CategoryDtos;

namespace ClkEmlak.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<ResultCategoryDto>
    {
        Task TChangeCategoryStatus(int id);
    }
}
