using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.Commands
{
    public class ProcessCreditCardDebitCommand : CreditCardCommand
    {
        public ProcessCreditCardDebitCommand(string id, double amount)
        {
            Id = id;
            Amount = amount;
        }

    }
}
