using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        public static decimal bankingBalance = 5000;
        public static bool runLoop = true;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank of Tre");
            Interface();
        }

        public static void Interface()
        {
            while (runLoop)
            {
                string userMenuSelection;
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Deposit Money");
                Console.WriteLine("4. Exit");
                userMenuSelection = Console.ReadLine();
                
                try
                {
                    switch (userMenuSelection)
                    {
                        case "1":
                            Console.WriteLine(ViewBankingBalance());
                            break;
                        case "2":
                            decimal amountUserWantsToWithdrawFromBankAccount;
                            Console.WriteLine("How much would you like to withdraw?");
                            amountUserWantsToWithdrawFromBankAccount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(WithDrawFromBankAccountBalance(amountUserWantsToWithdrawFromBankAccount));
                            Console.WriteLine(ViewBankingBalance());
                            break;
                        case "3":
                            decimal amountUserWantsToDepositInBankAccount;
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
                    Console.WriteLine("Your business is our first priority.");
                }
            }
        }

        public static void DepositMoneyToBankAccountBalance(string v)
        {
            throw new NotImplementedException();
        }

        public static object WithDrawFromBankAccountBalance(string v)
        {
            throw new NotImplementedException();
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

        public static string WithDrawFromBankAccountBalance(decimal amountUserWantsToWithdrawFromBankAccount)
        {
            if (bankingBalance <= 0)
            {
                return "Error: Insufficient funds";
            }
            else
            {
                try
                {
                    if (amountUserWantsToWithdrawFromBankAccount > 0 && amountUserWantsToWithdrawFromBankAccount <= bankingBalance)
                    {
                        bankingBalance -= amountUserWantsToWithdrawFromBankAccount;
                        return $"Transaction Successful: withdrew {amountUserWantsToWithdrawFromBankAccount}";
                    }
                    else
                    {
                        return "Sorry, amount entered was either a negative amount or exceeds bank account amount.";
                    }
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }


        public static string DepositMoneyToBankAccountBalance(decimal amountUserWantsToDepositInBankAccount)
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
