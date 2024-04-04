using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Concrete;
using ClkEmlak.DataAccessLayer.Repositories;
using ClkEmlak.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClkEmlak.DataAccessLayer.EntityFramework
{
    public class EfImageDal : GenericRepository<Image>, IImageDal
    {
        public EfImageDal(ClkContext context) : base(context)
        {
        }

        public async Task<List<Image>> ImageListByEstate(int id)
        {
            var context = new ClkContext();
            var values = await context.Images.Where(x => x.EstateID == id).ToListAsync();
            return values;
        }
    }
}
