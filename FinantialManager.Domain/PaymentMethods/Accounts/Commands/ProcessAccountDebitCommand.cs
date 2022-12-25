using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Commands
{
    public class ProcessAccountDebitCommand : AccountCommand
    {
        public ProcessAccountDebitCommand(string id, double amount)
        {
            Id = id;
            Amount = amount;
        }

    }
}
