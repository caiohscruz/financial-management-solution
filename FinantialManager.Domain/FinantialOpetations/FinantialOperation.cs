using FinantialManager.Domain.Core.Entitities;
using FinantialManager.Domain.PaymentMethods;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;

namespace FinantialManager.Domain.FinantialOpetations
{
    public abstract class FinantialOperation : Entity
    {
        public string Name { get; protected set; }

        protected double _amount { get; set; }
        public double Amount
        {
            get
            {
                return _amount;
            }
            protected set
            {
                if (value <= 0) throw new ArgumentException("A Finantial Operation must have a positive number as the amount");
                _amount = value;
            }
        }

        //TODO: Add Date and Processed properties

        public PaymentMethod Target { get; protected set; }

        public FinantialOperation(string name, double amount, PaymentMethod target) : base()
        {
            Name = name;
            Amount = amount;
            Target = target;
        }

        public FinantialOperation(string id, string name, double amount, PaymentMethod target) : base(id)
        {
            Name = name;
            Amount = amount;
            Target = target;
        }

        public abstract FinantialOperation UpdateName(string newName);

        public abstract FinantialOperation UpdateAmount(double amount);

        public abstract FinantialOperation UpdateTarget(PaymentMethod target);
    }
}
