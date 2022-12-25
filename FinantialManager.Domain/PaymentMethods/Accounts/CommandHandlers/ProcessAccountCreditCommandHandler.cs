using FinantialManager.Domain.PaymentMethods.Accounts.Commands;
using FinantialManager.Domain.PaymentMethods.Accounts.Interfaces;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;
using MediatR;

namespace FinantialManager.Domain.PaymentMethods.Accounts.CommandHandlers
{
    public class ProcessAccountCreditCommandHandler : IRequestHandler<ProcessAccountCreditCommand, bool>
    {
        private readonly IAccountRepository _accountRepository;

        public ProcessAccountCreditCommandHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<bool> Handle(ProcessAccountCreditCommand request, CancellationToken cancellationToken)
        {
            Account account = _accountRepository.GetById(request.Id);

            account = account.ProcessCredit(request.Amount);

            _accountRepository.Update(account);

            return Task.FromResult(true);
        }
    }
}
