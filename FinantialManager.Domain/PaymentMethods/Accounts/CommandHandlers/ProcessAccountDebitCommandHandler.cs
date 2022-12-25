using FinantialManager.Domain.PaymentMethods.Accounts.Commands;
using FinantialManager.Domain.PaymentMethods.Accounts.Interfaces;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.Accounts.CommandHandlers
{
    public class ProcessAccountDebitCommandHandler : IRequestHandler<ProcessAccountDebitCommand, bool>
    {
        private readonly IAccountRepository _accountRepository;

        public ProcessAccountDebitCommandHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<bool> Handle(ProcessAccountDebitCommand request, CancellationToken cancellationToken)
        {
            Account account = _accountRepository.GetById(request.Id);

            account = account.ProcessDebit(request.Amount);

            _accountRepository.Update(account);

            return Task.FromResult(true);
        }
    }
}
