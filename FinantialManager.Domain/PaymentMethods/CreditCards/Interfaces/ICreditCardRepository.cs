using FinantialManager.Domain.PaymentMethods.CreditCards.Models;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.Interfaces
{
    public interface ICreditCardRepository
    {
        void Create(CreditCard account);
        CreditCard GetById(string id);
        void Update(CreditCard account);
        void DeleteById(string id);

    }
}
