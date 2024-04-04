using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Concrete;
using ClkEmlak.DataAccessLayer.Repositories;
using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(ClkContext context) : base(context)
        {
        }
    }
}
