using FinantialManager.Domain.PaymentMethods.CreditCards.Commands;
using FinantialManager.Domain.PaymentMethods.CreditCards.Interfaces;
using FinantialManager.Domain.PaymentMethods.CreditCards.Models;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.CommandHandlers
{
    public class UpdateCreditCardNameCommandHandler : IRequestHandler<UpdateCreditCardNameCommand, bool>
    {
        private readonly ICreditCardRepository _creditCardRepository;

        public UpdateCreditCardNameCommandHandler(ICreditCardRepository creditCardRepository)
        {
            _creditCardRepository = creditCardRepository;
        }

        public Task<bool> Handle(UpdateCreditCardNameCommand request, CancellationToken cancellationToken)
        {
            CreditCard account = _creditCardRepository.GetById(request.Id);

            account = account.UpdateName(request.Name);

            _creditCardRepository.Update(account);

            return Task.FromResult(true);
        }
    }
}
