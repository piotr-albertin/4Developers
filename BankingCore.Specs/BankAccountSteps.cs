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
        
        [When(@"I deposit 100")]
        public void WhenIDeposit100()
        {
            bankAccount.Deposit(100);
        }
        
        [Then(@"My account balance should be 100")]
        public void ThenMyAccountBalanceShouldBe100()
        {
            Assert.Equal(100, bankAccount.Balance);
        }
        
    }
}
