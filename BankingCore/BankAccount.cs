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

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

    }
}
