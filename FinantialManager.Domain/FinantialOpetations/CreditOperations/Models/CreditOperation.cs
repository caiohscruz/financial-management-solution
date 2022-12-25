using FinantialManager.Domain.Core.Entitities;
using FinantialManager.Domain.PaymentMethods;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;

namespace FinantialManager.Domain.FinantialOpetations.CreditOperations.Models
{
    public class CreditOperation : FinantialOperation
    {
        public CreditOperation(string name, double amount, PaymentMethod target) : base(name, amount, target) { }
        public CreditOperation(string id, string name, double amount, PaymentMethod target) : base(id, name, amount, target) { }

        public override CreditOperation UpdateName(string newName)
        {
            return new CreditOperation(Id, newName, Amount, Target);
        }

        public override CreditOperation UpdateAmount(double newAmount)
        {
            return new CreditOperation(Id, Name, newAmount, Target);
        }

        public override CreditOperation UpdateTarget(PaymentMethod newTarget)
        {
            return new CreditOperation(Id, Name, Amount, newTarget);
        }
    }
}
