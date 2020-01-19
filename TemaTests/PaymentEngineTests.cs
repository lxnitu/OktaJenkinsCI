using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tema.Tests
{
    [TestClass()]
    public class PaymentEngineTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            Account account = new Account();

            account.LoadSold(1000);

            account.Withdraw(100);

            Assert.AreEqual(account.Sold, 900);
        }

        [TestMethod()]
        public void WithdrawOverflowTest_Throws()
        {
            Assert.ThrowsException<System.ArgumentException>(() =>
            {
                Account account = new Account();
                account.LoadSold(10);

                account.Withdraw(50);
            });
        }
    }
}