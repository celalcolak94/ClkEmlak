using ClkEmlak.DtoLayer.EstateDtos;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.BusinessLayer.Abstract
{
    public interface IEstateService : IGenericService<ResultEstateDto>
    {
        Task<List<EstateWithCategoryDto>> TEstateListByHomePage();
        Task<List<EstateWithCategoryDto>> TEstateListByStatusTrue();
        Task<List<EstateWithCategoryDto>> TEstateListByForSale();
        Task<List<EstateWithCategoryDto>> TEstateListByForRent();
		Task<int> TEstateCountByForSale();
        Task<int> TEstateCountByForRent();
		Task<ResultEstateDto> TGetByIdEstateWithImage(int id);
	}
}
