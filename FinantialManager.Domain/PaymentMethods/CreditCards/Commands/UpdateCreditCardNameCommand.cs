namespace FinantialManager.Domain.PaymentMethods.CreditCards.Commands
{
    public class UpdateCreditCardNameCommand : CreditCardCommand
    {
        public UpdateCreditCardNameCommand(string id, string newName)
        {
            Id = id;
            Name = newName;
        }

    }
}
