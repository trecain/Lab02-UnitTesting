using System;
using Xunit;
using Lab02_UnitTest;

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
    }
}
