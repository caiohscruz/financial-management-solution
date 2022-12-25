using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Commands
{
    public class ProcessAccountCreditCommand : AccountCommand
    {
        public ProcessAccountCreditCommand(string id, double amount)
        {
            Id = id;
            Amount = amount;
        }

    }
}
