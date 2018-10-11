using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        public static double bankingBalance = 5000;
        public static bool runLoop = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank of Tre");
            Interface();
        }

        public static void Interface()
        {
            string userMenuSelection;
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Deposit Money");
            Console.WriteLine("4. Exit");
            userMenuSelection = Console.ReadLine();

            while (runLoop)
            {
                try
                {
                    switch (userMenuSelection)
                    {
                        case "1":
                            Console.WriteLine(ViewBankingBalance());
                            runLoop = false;
                            break;
                        case "2":
                            double amountUserWantsToWithdrawFromBankAccount;
                            Console.WriteLine("How much would you like to withdraw?");
                            amountUserWantsToWithdrawFromBankAccount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(WithDrawFromBankAccountBalance(amountUserWantsToWithdrawFromBankAccount));
                            Console.WriteLine(ViewBankingBalance());
                            break;
                        case "3":
                            double amountUserWantsToDepositInBankAccount;
                            Console.WriteLine("How much would you like to Deposit?");
                            amountUserWantsToDepositInBankAccount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DepositMoneyToBankAccountBalance(amountUserWantsToDepositInBankAccount));
                            Console.WriteLine(ViewBankingBalance());
                            break;
                        case "4":
                            Console.WriteLine("Thank you for coming by.");
                            StopTheLoop();
                            break;
                        default:
                            Console.WriteLine("You have selected something off the menu");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid request. Transaction has been terminated.");
                }
                finally
                {
                    Console.WriteLine("Patience is a virtue");
                }
            }
        }


        //Shows user the current bank account balance.

        public static string ViewBankingBalance()
        {
            return $"Your current bank account balance is: {bankingBalance}";
        }

        public static void StopTheLoop()
        {
            runLoop = false;
        }


        //Saves the amount the user wants to withdraw in a variable and subtracts it from banking balance.
        //Also checks to see if user has money in bank account and if the amount they wanted to withdraw is not a negative number.

        public static string WithDrawFromBankAccountBalance(double amountUserWantsToWithdrawFromBankAccount)
        {
            if (bankingBalance <= 0)
            {
                return "Error: Insufficient funds";
            }
            else
            {
                try
                {
                    if (amountUserWantsToWithdrawFromBankAccount > 0)
                    {
                        bankingBalance -= amountUserWantsToWithdrawFromBankAccount;
                        StopTheLoop();
                        return $"Transaction Successful: withdrew {amountUserWantsToWithdrawFromBankAccount}";
                    }
                    else
                    {
                        return "Sorry, amount entered was not a positive number";
                    }
                }
                catch(Exception)
                {
                    throw;
                }
               
            }
        }


        public static string DepositMoneyToBankAccountBalance(double amountUserWantsToDepositInBankAccount)
        {
            if (amountUserWantsToDepositInBankAccount < 0)
            {
                return "Error: Insufficient deposit amount";
            }
            else
            {
                try
                {
                    bankingBalance += amountUserWantsToDepositInBankAccount;
                    StopTheLoop();
                    return $"Transaction Successful: deposited {amountUserWantsToDepositInBankAccount}";
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }
}
