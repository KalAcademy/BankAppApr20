using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating an instance of an account == object!
            var myFirstAccount = Bank.CreateAccount("My checking", "test@test.com", TypeOfAccounts.Checking);
            myFirstAccount.Deposit(123456);
            Console.WriteLine($"AN: {myFirstAccount.AccountNumber}, Name: {myFirstAccount.AccountName}, Email: {myFirstAccount.EmailAddress}, B: {myFirstAccount.Balance:C}, CD: {myFirstAccount.CreatedDate}, AT: {myFirstAccount.AccountType}");

            var mySecondAccount = Bank.CreateAccount("My savings", "test@test.com", TypeOfAccounts.Savings);
            Console.WriteLine($"AN: {mySecondAccount.AccountNumber}, Name: {mySecondAccount.AccountName}, Email: {mySecondAccount.EmailAddress}, B: {mySecondAccount.Balance:C}, CD: {mySecondAccount.CreatedDate}, AT: {mySecondAccount.AccountType}");

            var myThirdAccount = Bank.CreateAccount("My CD", "test@test.com", TypeOfAccounts.CD);
            Console.WriteLine($"AN: {myThirdAccount.AccountNumber}, Name: {myThirdAccount.AccountName}, Email: {myThirdAccount.EmailAddress}, B: {myThirdAccount.Balance:C}, CD: {myThirdAccount.CreatedDate}, AT: {myThirdAccount.AccountType}");


        }
    }
}
