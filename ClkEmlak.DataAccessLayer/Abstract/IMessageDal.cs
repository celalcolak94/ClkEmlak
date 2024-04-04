using ClkEmlak.EntityLayer.Entities;

namespace ClkEmlak.DataAccessLayer.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        Task<int> ComingMessageCount();
    }
}
