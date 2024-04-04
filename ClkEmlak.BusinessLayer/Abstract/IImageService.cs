using ClkEmlak.DtoLayer.ImageDtos;

namespace ClkEmlak.BusinessLayer.Abstract
{
    public interface IImageService : IGenericService<ResultImageDto>
    {
        Task<List<ResultImageDto>> TImageListByEstate(int id);
    }
}
