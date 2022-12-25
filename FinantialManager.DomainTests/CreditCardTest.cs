using FinantialManager.Domain.PaymentMethods.CreditCards.Models;

namespace FinantialManager.DomainTests
{
    [TestClass]
    public class CreditCardTest
    {
        [DataTestMethod]
        [DataRow("123", "Old Name", 100, "New Name")]
        public void Should_UpdateCreditCardName_When_UpdateName(string id, string oldName,double balance, string newName)
        {
            var creditCard = new CreditCard(id, oldName, balance);

            creditCard = creditCard.UpdateName(newName);

            Assert.AreEqual(newName, creditCard.Name);
        }

        [DataTestMethod]
        [DataRow("123", "CreditCard Name", 100, 20)]
        public void Should_IncreaseCreditCardDebt_When_IncreaseDebt(string id, string name, double balance, double amount)
        {
            CreditCard creditCard = new CreditCard(id, name, balance);
            double newDebt = creditCard.Debt + amount;

            creditCard = creditCard.ProcessDebit(amount);

            Assert.AreEqual(newDebt, creditCard.Debt);
        }

        [DataTestMethod]
        [DataRow("123", "CreditCard Name", 100, 20)]
        public void Should_DecreaseCreditCardDebt_When_DeductDebt(string id, string name, double balance, double amount)
        {
            CreditCard creditCard = new CreditCard(id, name, balance);
            double newDebt = creditCard.Debt - amount;

            creditCard = creditCard.ProcessCredit(amount);

            Assert.AreEqual(newDebt, creditCard.Debt);
        }
    }
}