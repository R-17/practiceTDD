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
            bankAccount.Transactions.Add(120.0, '01/01/2023');

            List<Transaction> list= new List<Transaction>();
            bankAccount.SortByDate();
            Assert.AreEqual(list, bankAccount.Transactions);
        }

        [TestMethod]
        public void Total_Amount()
        {
            BankAccount account = new BankAccount();

        }
    }
}