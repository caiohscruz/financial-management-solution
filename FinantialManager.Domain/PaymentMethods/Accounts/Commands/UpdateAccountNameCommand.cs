using FinantialManager.Domain.Core.Commands;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Commands
{
    public class UpdateAccountNameCommand : AccountCommand
    {
        public UpdateAccountNameCommand(string id, string newName)
        {
            Id = id;
            Name = newName;
        }

    }
}
