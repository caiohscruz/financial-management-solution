using FinantialManager.Domain.Core.Entitities;

namespace FinantialManager.Domain.PaymentMethods.Accounts.Models
{
    public class Account : PaymentMethod
    {
        public double Balance { get; private set; }

        // make internal
        public Account(string id, string name, double balance) : base(id, name)
        {
            Balance = balance;
        }
        public Account(string name, double balance) : base(name)
        {
            Balance = balance;
        }
        public override Account UpdateName(string newName)
        {
            return new Account(Id, newName, Balance);
        }

        public override Account ProcessCredit(double amount)
        {
            // dispatch AccountBalanceUpdated event
            var newBalance = Balance + amount;
            return new Account(Id, Name, newBalance);
        }

        public override Account ProcessDebit(double amount)
        {
            // dispatch AccountBalanceUpdated event
            var newBalance = Balance - amount;
            return new Account(Id, Name, newBalance);
        }

    }
}
