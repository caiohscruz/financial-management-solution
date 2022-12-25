using FinantialManager.Domain.Core.Entitities;
using FinantialManager.Domain.PaymentMethods;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;

namespace FinantialManager.Domain.FinantialOpetations.DebitOperations.Models
{
    public class DebitOperation : FinantialOperation
    {
        public DebitOperation(string name, double amount, PaymentMethod target) : base(name, amount, target) { }
        public DebitOperation(string id, string name, double amount, PaymentMethod target) : base(id, name, amount, target) { }

        public override DebitOperation UpdateName(string newName)
        {
            return new DebitOperation(Id, newName, Amount, Target);
        }

        public override DebitOperation UpdateAmount(double newAmount)
        {
            return new DebitOperation(Id, Name, Amount, Target);
        }

        public override DebitOperation UpdateTarget(PaymentMethod newTarget)
        {
            return new DebitOperation(Id, Name, Amount, newTarget);
        }

    }

}
