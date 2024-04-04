using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.DataAccessLayer.Abstract
{
    public interface IImageDal : IGenericDal<Image>
    {
        Task<List<Image>> ImageListByEstate(int id);
    }
}
