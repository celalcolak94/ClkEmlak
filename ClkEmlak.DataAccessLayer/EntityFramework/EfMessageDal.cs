using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Concrete;
using ClkEmlak.DataAccessLayer.Repositories;
using ClkEmlak.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClkEmlak.DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        private readonly ClkContext _context;
        public EfMessageDal(ClkContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> ComingMessageCount()
        {
            var value = await _context.Messages.ToListAsync();
            return value.Count;
        }
    }
}
