using FinantialManager.Domain.PaymentMethods.CreditCards.Models;
using FinantialManager.Domain.PaymentMethods.CreditCards.Commands;
using FinantialManager.Domain.PaymentMethods.CreditCards.Interfaces;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.CommandHandlers
{
    public class CreateCreditCardCommandHandler : IRequestHandler<CreateCreditCardCommand, bool>
    {
        private readonly ICreditCardRepository _creditCardRepository;

        public CreateCreditCardCommandHandler(ICreditCardRepository accountRepository)
        {
            _creditCardRepository = accountRepository;
        }

        public Task<bool> Handle(CreateCreditCardCommand request, CancellationToken cancellationToken)
        {
            var creditCard = new CreditCard(name: request.Name, debt: request.Debt);

            _creditCardRepository.Create(creditCard);

            return Task.FromResult(true);
        }
    }
}
