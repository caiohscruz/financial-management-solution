using FinantialManager.Domain;

namespace FinantialManager.DomainTests
{
    [TestClass]
    public class CreditCardTest
    {
        [DataTestMethod]
        [DataRow("123", "CreditCard Name")]
        public void Should_ReturnAnCreditCardWithoutDebt_When_DebtNotInformed(string id, string name)
        {
            var CreditCard = new CreditCard(id, name);

            Assert.AreEqual(0, CreditCard.Debt);
        }

        [DataTestMethod]
        [DataRow("123", "CreditCard Name", 50)]
        public void Should_ReturnAnCreditCardWithoutDebt_When_DebtInformed(string id, string name, double Debt)
        {
            var CreditCard = new CreditCard(id, name, Debt);

            Assert.AreEqual(Debt, CreditCard.Debt);
        }

        [DataTestMethod]
        [DataRow("123", "Old Name", "New Name")]
        public void Should_UpdateCreditCardName_When_UpdateName(string id, string oldName, string newName)
        {
            var CreditCard = new CreditCard(id, oldName);

            CreditCard.UpdateName(newName);

            Assert.AreEqual(newName, CreditCard.Name);
        }

        [DataTestMethod]
        [DataRow("123", "CreditCard Name", 100)]
        public void Should_IncreaseCreditCardDebt_When_IncreaseDebt(string id, string name, double amount)
        {
            CreditCard CreditCard = new CreditCard(id, name);
            double newDebt = CreditCard.Debt + amount;

            CreditCard.IncreaseDebt(amount);

            Assert.AreEqual(newDebt, CreditCard.Debt);
        }

        [DataTestMethod]
        [DataRow("123", "CreditCard Name", 100)]
        public void Should_DecreaseCreditCardDebt_When_DeductDebt(string id, string name, double amount)
        {
            CreditCard CreditCard = new CreditCard(id, name);
            double newDebt = CreditCard.Debt - amount;

            CreditCard.DeductDebt(amount);

            Assert.AreEqual(newDebt, CreditCard.Debt);
        }
    }
}