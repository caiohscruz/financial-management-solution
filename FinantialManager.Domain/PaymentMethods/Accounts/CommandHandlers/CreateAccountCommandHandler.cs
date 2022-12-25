using FinantialManager.Domain.PaymentMethods.Accounts.Models;
using FinantialManager.Domain.PaymentMethods.Accounts.Commands;
using FinantialManager.Domain.PaymentMethods.Accounts.Interfaces;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.Accounts.CommandHandlers
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, bool>
    {
        private readonly IAccountRepository _accountRepository;

        public CreateAccountCommandHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<bool> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var account = new Account()
            {
                Name = request.Name,
                Balance = request.Balance
            };

            _accountRepository.Create(account);

            return Task.FromResult(true);
        }
    }
}
