using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Commands
{
    public class CreateAccountCommand : AccountCommand
    {
        public CreateAccountCommand(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
