using FinantialManager.Domain.PaymentMethods.Accounts.Commands;
using FinantialManager.Domain.PaymentMethods.Accounts.Interfaces;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.Accounts.CommandHandlers
{
    public class UpdateAccountNameCommandHandler : IRequestHandler<UpdateAccountNameCommand, bool>
    {
        private readonly IAccountRepository _accountRepository;

        public UpdateAccountNameCommandHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<bool> Handle(UpdateAccountNameCommand request, CancellationToken cancellationToken)
        {
            Account account = _accountRepository.GetById(request.Id);

            account = account.UpdateName(request.Name);

            _accountRepository.Update(account);

            return Task.FromResult(true);
        }
    }
}
