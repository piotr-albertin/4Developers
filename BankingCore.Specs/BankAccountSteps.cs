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

        [Then(@"My account balance should be (.*)")]
        public void ThenMyAccountBalanceShouldBeAmount(decimal amount)
        {
            Assert.Equal(amount, bankAccount.Balance);
        }

    }
}
