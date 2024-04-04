using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Concrete;
using ClkEmlak.DataAccessLayer.Repositories;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly ClkContext _context;
        public EfCategoryDal(ClkContext context) : base(context)
        {
            _context = context;
        }

        public async Task ChangeCategoryStatus(int id)
        {
            var value = await _context.Categories.FindAsync(id);
            if (value != null)
            {
                value.Status = !value.Status;
                _context.Categories.Update(value);
                await _context.SaveChangesAsync();
            }
        }
    }
}
