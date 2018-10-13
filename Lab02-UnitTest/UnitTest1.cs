using System;
using Xunit;
using Lab02_UnitTesting;

namespace Lab02_UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShowCashBalance()
        {
            Program.bankingBalance = 5000;
            Assert.Equal("Your current bank account balance is: 5000", Program.ViewBankingBalance());
        }

        [Fact]
        public void CantWithdrawFromZeroBankAccount()
        {
            Program.bankingBalance = 0;
            Assert.Equal("Error: Insufficient funds", Program.WithDrawFromBankAccountBalance(600));
        }

        [Fact]

        public void CantWithdrawNegativeNumbers()
        {
            Assert.Equal("Sorry, amount entered was either a negative amount or exceeds bank account amount.", Program.WithDrawFromBankAccountBalance(-1));
        }

        [Theory]
        [InlineData(500, 0, "Error: Insufficient funds")]
        public string CanWithdrawFromBankAccountBalance(decimal withdrawAmount, decimal bankingBalance, string expectedResult)
        {
            Program.bankingBalance = bankingBalance;
            var result = Program.WithDrawFromBankAccountBalance(withdrawAmount);

            Assert.Equal(expectedResult, result);
        }

    }
}
