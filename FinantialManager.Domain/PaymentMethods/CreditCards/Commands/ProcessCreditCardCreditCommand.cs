using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.Commands
{
    public class ProcessCreditCardCreditCommand : CreditCardCommand
    {
        public ProcessCreditCardCreditCommand(string id, double amount)
        {
            Id = id;
            Amount = amount;
        }

    }
}
