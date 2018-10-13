using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02_UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShowCashBalance() //Test that banking balance is shown correctly
        {
            Program.bankingBalance = 5000;
            Assert.Equal("Your current bank account balance is: 5000", Program.ViewBankingBalance());
        }

        [Fact]
        public void CantWithdrawFromZeroBankAccount() //Test that a withdraw can't be made with a zero balance
        {
            Program.bankingBalance = 0;
            Assert.Equal("Error: Insufficient funds", Program.WithDrawFromBankAccountBalance(600));
        }

        [Fact]

        public void CantWithdrawNegativeNumbers() //Test that a withdraw of negative integer can't be made
        {
            Assert.Equal("Sorry, amount entered was either a negative amount or exceeds bank account amount.", Program.WithDrawFromBankAccountBalance(-1));
        }

        [Theory]
        //Different Theory test
        [InlineData(500, 0, "Error: Insufficient funds")]
        [InlineData(1000, 5000, "Transaction Successful: withdrew 1000")]
        [InlineData(-100, 5000, "Sorry, amount entered was either a negative amount or exceeds bank account amount.")]

        //Test that user can withdraw money from bank account
        //Also test that a negative number gives proper message.
        //Test if user has zero dollars in bank account.
        public void CanWithdrawFromBankAccountBalance(decimal withdrawAmount, decimal bankingBalance, string expectedResult)
        {
            Program.bankingBalance = bankingBalance;
            var result = Program.WithDrawFromBankAccountBalance(withdrawAmount);
            Assert.Equal(expectedResult, result);
        }
        
        [Fact] 
        public void WillThrowExceptionForWithdraw() //Test that an exception is thrown when user inputs incorrect value.
        {
            var result = Record.Exception(() => Program.WithDrawFromBankAccountBalance("Hello World"));
            Assert.IsType<NotImplementedException>(result);
        }

        [Theory]
        [InlineData(-1, "Error: Insufficient deposit amount")]
        [InlineData(5000, "Transaction Successful: deposited 5000")]

        //Test that a user can't deposit negative dollars.
        //Test that user can make successful deposits.
        public void CanDepositToBankAccountBalance(decimal depositAmount, string expectedResult)
        {
            var result = Program.DepositMoneyToBankAccountBalance(depositAmount);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void WillThrowExceptionForDeposit() //Test that an exception is thrown when user inputs incorrect value.
        {
            var result = Record.Exception(() => Program.DepositMoneyToBankAccountBalance("turtle"));
            Assert.IsType<NotImplementedException>(result);
        }

    }
}
