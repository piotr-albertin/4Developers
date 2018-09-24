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
        
        [When]
        public void When_I_deposit_200()
        {
            bankAccount.Deposit(200);
        }

        [Then(@"My account balance should be 100")]
        public void ThenMyAccountBalanceShouldBe100()
        {
            Assert.Equal(100, bankAccount.Balance);
        }
        
        [Then]
        public void ThenMyAccountBalanceShouldBe_300()
        {
            Assert.Equal(300, bankAccount.Balance);
        }


    }
}
