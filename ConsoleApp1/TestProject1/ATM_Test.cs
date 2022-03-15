using System;
using Xunit;


namespace TestProject1
{
    public class ATM_Test
    {
        [Fact]
        public void Balance_Test()
        {
            decimal balance = 100;

            Assert.Equal(balance, 100);
            
        }

        [Fact]
        public void Withdraw_Test()
        {

            // if balance after subtract the Withdraw value
            // not changed , then the Withdraw method is not working well .
            decimal balance = 100;
            decimal WithdrawValue = 10;
            decimal result = balance - WithdrawValue;

            Assert.NotEqual(result, balance);

        }

        [Fact]
        public void Deposit_Test()
        {
            // if balance after add the Deposit value
            // not changed , then the Deposit method is not working well .

            decimal balance = 100;
            decimal DepositValue = 10;
            decimal result = balance + DepositValue;

            Assert.NotEqual(result, balance);

        }
    }
}
