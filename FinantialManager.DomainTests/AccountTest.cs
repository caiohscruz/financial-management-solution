using FinantialManager.Domain.PaymentMethods.Accounts.Models;

namespace FinantialManager.DomainTests
{
    [TestClass]
    public class AccountTest
    {    
        
        [DataTestMethod]
        [DataRow("123", "Old Name", 100, "New Name")]
        public void Should_UpdateAccountName_When_UpdateName(string id, string oldName, double balance, string newName)
        {
            var account = new Account(id, oldName, balance);

            account = account.UpdateName(newName);

            Assert.AreEqual(newName, account.Name);
        }

        [DataTestMethod]
        [DataRow("123", "Account Name", 100, 20)]
        public void Should_IncreaseAccountBalance_When_ProcessCredit(string id, string name, double balance, double amount)
        {
            Account account = new Account(id, name, balance);
            double newBalance = account.Balance + amount;

            account = account.ProcessCredit(amount);
            
            Assert.AreEqual(newBalance, account.Balance);
        }

        [DataTestMethod]
        [DataRow("123", "Account Name", 100, 20)]
        public void Should_DecreaseAccountBalance_When_ProcessDebit(string id, string name, double balance, double amount)
        {
            Account account = new Account(id, name, balance);
            double newBalance = account.Balance - amount;

            account = account.ProcessDebit(amount);

            Assert.AreEqual(newBalance, account.Balance);
        }
    }
}