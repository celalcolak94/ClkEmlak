using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Concrete;
using ClkEmlak.DataAccessLayer.Repositories;
using ClkEmlak.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClkEmlak.DataAccessLayer.EntityFramework
{
	public class EfEstateDal : GenericRepository<Estate>, IEstateDal
    {
        public EfEstateDal(ClkContext context) : base(context)
        {
        }

		public async Task<int> EstateCountByForRent()
        {
            var context = new ClkContext();
            var value = await context.Estates.Where(x => x.CategoryID == 2).ToListAsync();
            return value.Count;
        }

        public async Task<int> EstateCountByForSale()
		{
			var context = new ClkContext();
            var value = await context.Estates.Where(x => x.CategoryID == 1).ToListAsync();
            return value.Count;
		}

		public async Task<List<Estate>> EstateListByForRent()
        {
            var context = new ClkContext();
            var values = await context.Estates.Include(y => y.Category).Where(x => x.CategoryID == 2).ToListAsync();
            return values;
        }

        public async Task<List<Estate>> EstateListByForSale()
        {
            var context = new ClkContext();
            var values = await context.Estates.Include(y => y.Category).Where(x => x.CategoryID == 1).ToListAsync();
            return values;
        }

        public async Task<List<Estate>> EstateListByHomePage()
        {
            var context = new ClkContext();
            var values = await context.Estates.Include(y => y.Category).Where(x => x.HomePage == true).ToListAsync();
            return values;
        }

        public async Task<List<Estate>> EstateListByStatusTrue()
        {
            var context = new ClkContext();
            var values = await context.Estates.Include(y => y.Category).Where(x => x.Status == true).ToListAsync();
            return values;
        }

		public async Task<Estate> GetByIdEstateWithImage(int id)
		{
            var context = new ClkContext();
            var value = await context.Estates.Include(x => x.Images).FirstOrDefaultAsync(z => z.EstateID == id);
            return value;
		}
	}
}
