using FinantialManager.Domain.Core.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialManager.Domain.PaymentMethods.CreditCards.Models
{
    public class CreditCard : PaymentMethod
    {
        public double Debt { get; private set; }

        public CreditCard(string name, double debt) : base(name)
        {
            Debt = debt;
        }

        public CreditCard(string id, string name, double debt) : base(id, name)
        {
            Debt = debt;
        }

        public override CreditCard UpdateName(string newName)
        {
            return new CreditCard(Id, newName, Debt);
        }
        public override CreditCard ProcessCredit(double amount)
        {
            // dispatch CreditCardDebtUpdated event
            var newDebt = Debt - amount;
            return new CreditCard(Id, Name, newDebt);
        }

        public override CreditCard ProcessDebit(double amount)
        {
            // dispatch CreditCardDebtUpdated event
            var newDebt = Debt + amount;
            return new CreditCard(Id, Name, newDebt);
        }

    }
}
