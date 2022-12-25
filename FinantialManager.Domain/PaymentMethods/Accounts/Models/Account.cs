using FinantialManager.Domain.Core.Entitities;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Models
{
    public class Account : PaymentMethod
    {
        public double Balance { get; set; } = 0;
        
    }
}
