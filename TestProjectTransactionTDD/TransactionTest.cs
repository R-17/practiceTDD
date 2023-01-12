using ClassLibraryTransactionTDD;


namespace TestProjectTransactionTDD
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void Sorted_List()
        {
            BankAccount bankAccount = new BankAccount();
            List<Transaction> list= new List<Transaction>();
            bankAccount.SortByDate();
            Assert.AreEqual(list, bankAccount.Transactions);
        }

        [TestMethod]
        public void Total_Amount()
        {

        }
    }
}