using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of an account == object!
            var myFirstAccount = new Account();
            myFirstAccount.AccountNumber = 1234;
            myFirstAccount.AccountName = "My checking";
            myFirstAccount.AccountType = "Checking";
            myFirstAccount.EmailAddress = "test@test.com";
            myFirstAccount.Deposit(123456);

            var mySecondAccount = new Account();
            mySecondAccount.AccountNumber = 45678;
            mySecondAccount.AccountName = "My savings";


        }
    }
}
