namespace ClassLibraryTransactionTDD
{
    public class BankAccount
    {
        private List<Transaction> transactions;
        private double totalAmount;
        public BankAccount()
        {
            transactions = new List<Transaction>();
        }

        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public List<Transaction> SortByDate()
        {
            return trans;
        }

        public double Total()
        {
            return trans;
        }
    }
}