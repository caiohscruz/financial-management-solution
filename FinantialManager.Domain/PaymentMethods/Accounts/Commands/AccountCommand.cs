using FinantialManager.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Commands
{
    public abstract class AccountCommand : Command
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public double Balance { get; protected set; }
        public double Amount { get; protected set; }
    }
}
