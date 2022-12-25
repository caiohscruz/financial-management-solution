using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinantialManager.Domain.PaymentMethods.Accounts.Models;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
        Account GetById(string id);
        void Update(Account account);
        void DeleteById(string id);

    }
}
