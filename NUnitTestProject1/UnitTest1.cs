using NUnit.Framework;
using Tema;

namespace Tests
{
    public class PaymentEngineTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WithdrawTest()
        {
            Account account = new Account();

            account.LoadSold(1000);

            account.Withdraw(100);

            Assert.AreEqual(account.Sold, 900);
        }

        [Test]
        public void WithdrawOverflowTest_Throws()
        {
            //Assert.ThrowsException<System.ArgumentException>(() =>
            //{
            //    Account account = new Account();
            //    account.LoadSold(10);

            //    account.Withdraw(50);
            //});
        }
    }
}