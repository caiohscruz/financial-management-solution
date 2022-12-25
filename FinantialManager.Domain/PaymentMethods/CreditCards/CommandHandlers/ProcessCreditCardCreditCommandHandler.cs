using FinantialManager.Domain.PaymentMethods.CreditCards.Commands;
using FinantialManager.Domain.PaymentMethods.CreditCards.Interfaces;
using FinantialManager.Domain.PaymentMethods.CreditCards.Models;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.CommandHandlers
{
    public class ProcessCreditCardCreditCommandHandler : IRequestHandler<ProcessCreditCardCreditCommand, bool>
    {
        private readonly ICreditCardRepository _creditCardRepository;

        public ProcessCreditCardCreditCommandHandler(ICreditCardRepository accountRepository)
        {
            _creditCardRepository = accountRepository;
        }

        public Task<bool> Handle(ProcessCreditCardCreditCommand request, CancellationToken cancellationToken)
        {
            CreditCard creditCard = _creditCardRepository.GetById(request.Id);

            creditCard = creditCard.ProcessCredit(request.Amount);

            _creditCardRepository.Update(creditCard);

            return Task.FromResult(true);
        }
    }
}
