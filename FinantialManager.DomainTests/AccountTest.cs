using FinantialManager.Domain;
using System.Xml.Linq;

namespace FinantialManager.DomainTests
{
    [TestClass]
    public class AccountTest
    {    
        
        [DataTestMethod]
        [DataRow("123", "Account Name")]
        public void Should_ReturnAnAccountWithoutBalance_When_BalanceNotInformed(string id, string name)
        {
            var account = new Account(id, name);
                                    
            Assert.AreEqual(0, account.Balance);
        }

        [DataTestMethod]
        [DataRow("123", "Account Name", 50)]
        public void Should_ReturnAnAccountWithoutBalance_When_BalanceInformed(string id, string name, double balance)
        {
            var account = new Account(id, name, balance);

            Assert.AreEqual(balance, account.Balance);
        }

        [DataTestMethod]
        [DataRow("123", "Old Name", "New Name")]
        public void Should_UpdateAccountName_When_UpdateName(string id, string oldName, string newName)
        {
            var account = new Account(id, oldName);

            account.UpdateName(newName);

            Assert.AreEqual(newName, account.Name);
        }

        [DataTestMethod]
        [DataRow("123", "Account Name", 100)]
        public void Should_IncreaseAccountBalance_When_Deposit(string id, string name, double amount)
        {
            Account account = new Account(id, name);
            double newBalance = account.Balance + amount;

            account.Deposit(amount);
            
            Assert.AreEqual(newBalance, account.Balance);
        }

        [DataTestMethod]
        [DataRow("123", "Account Name", 100)]
        public void Should_DecreaseAccountBalance_When_Withdraw(string id, string name, double amount)
        {
            Account account = new Account(id, name);
            double newBalance = account.Balance - amount;

            account.Withdraw(amount);

            Assert.AreEqual(newBalance, account.Balance);
        }
    }
}