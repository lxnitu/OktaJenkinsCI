using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tema;

namespace TransferTests.Tests
{
    [TestClass()]
    public class TransferTests
    {

        [TestMethod()]
        public void TransferFromTest()
        {
            Account accountFrom = new Account();
            Account accountTo = new Account();

            accountFrom.LoadSold(100);

            accountFrom.Transfer(30, accountTo);

            Assert.AreEqual(accountFrom.Sold, 70);
            Assert.AreEqual(accountTo.Sold, 30);
        }

        [TestMethod()]
        public void TransferFromTest_ThrowsExcedes()
        {
            Assert.ThrowsException<System.ArgumentException>(() =>
            {
                Account accountFrom = new Account();
                Account accountTo = new Account();

                accountFrom.LoadSold(100);

                accountFrom.Transfer(110, accountTo);
            });
        }

        [TestMethod()]
        public void TransferFromTest_ThrowsNullDestination()
        {
            Assert.ThrowsException<System.ArgumentNullException>(() =>
            {
                Account accountFrom = new Account();
                Account accountTo = null;

                accountFrom.LoadSold(100);

                accountFrom.Transfer(10, accountTo);
            });
        }
    }
}

