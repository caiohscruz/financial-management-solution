using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.Commands
{
    public abstract class CreditCardCommand : Command
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public double Debt { get; protected set; }
        public double Amount { get; protected set; }
    }
}
