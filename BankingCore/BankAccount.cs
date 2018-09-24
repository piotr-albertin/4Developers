namespace BankingCore
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }


        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }



    }
}
