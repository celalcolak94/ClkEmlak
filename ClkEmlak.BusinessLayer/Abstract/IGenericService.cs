namespace ClkEmlak.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<List<T>> TGetAllAsync();
        Task<T> TGetByIdAsync(int id);
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TRemoveAsync(T entity);
    }
}
