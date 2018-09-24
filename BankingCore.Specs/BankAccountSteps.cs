using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BankingCore.Specs
{
    [Binding]
    public class BankAccountSteps
    {
        private BankAccount bankAccount;

        [Given(@"I own a new bank account")]
        public void GivenIOwnANewBankAccount()
        {
            bankAccount = new BankAccount();
        }

        [When(@"I deposit (.*)")]
        public void WhenIDepositAmount(decimal amount)
        {
            bankAccount.Deposit(amount);
        }

        [When(@"I withdraw (.*)")]
        public void WhenIWithdrawAmount(int amount)
        {
            bankAccount.Withdraw(amount);
        }

        [When(@"I have performed following transactions")]
        public void WhenIHavePerformedFollowingTransactions(Table table)
        {
            foreach (var row in table.Rows)
            {
                var transaction = row["transaction"];
                var amount = decimal.Parse(row["amount"]);

                if (transaction == "deposit")
                {
                    bankAccount.Deposit(amount);
                }
                else if (transaction == "withdraw")
                {
                    bankAccount.Withdraw(amount);
                }
            }
        }


        [Then(@"My account balance should be (.*)")]
        public void ThenMyAccountBalanceShouldBeAmount(decimal amount)
        {
            Assert.Equal(amount, bankAccount.Balance);
        }

    }
}
