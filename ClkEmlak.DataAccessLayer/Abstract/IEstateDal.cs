using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.DataAccessLayer.Abstract
{
    public interface IEstateDal : IGenericDal<Estate>
    {
        Task<List<Estate>> EstateListByHomePage();
        Task<List<Estate>> EstateListByStatusTrue();
        Task<List<Estate>> EstateListByForSale();
        Task<List<Estate>> EstateListByForRent();
        Task<int> EstateCountByForSale();
        Task<int> EstateCountByForRent();
        Task<Estate> GetByIdEstateWithImage(int id);
    }
}
