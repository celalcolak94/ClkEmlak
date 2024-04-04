using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task ChangeCategoryStatus(int id);
    }
}
