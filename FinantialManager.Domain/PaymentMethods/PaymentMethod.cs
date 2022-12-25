using FinantialManager.Domain.Core.Entitities;

namespace FinantialManager.Domain.PaymentMethods
{
    public abstract class PaymentMethod : Entity
    {
        public string Name { get; protected set; }

        public PaymentMethod(string name):base()
        {
            Name= name;
        }
        public PaymentMethod(string id, string name) : base(id)
        {
            Name = name;
        }

        public abstract PaymentMethod UpdateName(string newName);
        public abstract PaymentMethod ProcessCredit(double amount);
        public abstract PaymentMethod ProcessDebit(double amount);

    }
}
