using FinantialManager.Domain.FinantialOpetations.Models;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;

namespace FinantialManager.Domain.FinantialOpetations.Interfaces
{
    public interface IFinantialOperationRepository
    {
        void Create(FinantialOperation finantialOperation);
        FinantialOperation GetById(string id);
        IQueryable<FinantialOperation> GetByOriginId(string originId);
        IQueryable<FinantialOperation> GetByTargetId(string targetId);
        void Update(FinantialOperation finantialOperation);
        void DeleteById(string id);
    }
}
