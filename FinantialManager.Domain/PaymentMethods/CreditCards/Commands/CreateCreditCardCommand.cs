namespace FinantialManager.Domain.PaymentMethods.CreditCards.Commands
{
    public class CreateCreditCardCommand : CreditCardCommand
    {
        public CreateCreditCardCommand(string name, double debt)
        {
            Name = name;
            Debt = debt;
        }
    }
}
