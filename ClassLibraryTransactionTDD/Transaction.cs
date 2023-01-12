namespace ClassLibraryTransactionTDD
{
    public class Transaction
    {
		private double amount;
		private DateTime date;

        public Transaction(double amount, DateTime date)
        {
			this.amount = amount;
			this.date = date;
        }

        public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}


		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

	}
}
