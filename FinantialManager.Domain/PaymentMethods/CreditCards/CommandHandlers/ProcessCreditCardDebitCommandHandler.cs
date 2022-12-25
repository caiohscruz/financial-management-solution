using FinantialManager.Domain.PaymentMethods.CreditCards.Commands;
using FinantialManager.Domain.PaymentMethods.CreditCards.Interfaces;
using FinantialManager.Domain.PaymentMethods.CreditCards.Models;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.CommandHandlers
{
    public class ProcessCreditCardDebitCommandHandler : IRequestHandler<ProcessCreditCardDebitCommand, bool>
    {
        private readonly ICreditCardRepository _creditCardRepository;

        public ProcessCreditCardDebitCommandHandler(ICreditCardRepository accountRepository)
        {
            _creditCardRepository = accountRepository;
        }

        public Task<bool> Handle(ProcessCreditCardDebitCommand request, CancellationToken cancellationToken)
        {
            CreditCard creditCard = _creditCardRepository.GetById(request.Id);

            creditCard.Debt += request.Amount;

            _creditCardRepository.Update(creditCard);

            return Task.FromResult(true);
        }
    }
}
