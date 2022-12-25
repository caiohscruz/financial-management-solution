using FinantialManager.Domain.Core.Entitities;

namespace FinantialManager.Domain.PaymentMethods
{
    public abstract class PaymentMethod : Entity
    {
        public string? Name { get;  set; } = string.Empty;      


    }
}
