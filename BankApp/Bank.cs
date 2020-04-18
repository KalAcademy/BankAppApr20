using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        private static BankContext db = new BankContext();
        /// <summary>
        /// Create an account with the bank
        /// </summary>
        /// <param name="accountName">Name of the account</param>
        /// <param name="emailAddress">Account holder's email address</param>
        /// <param name="accountType">Type of account</param>
        /// <returns></returns>
        public static Account CreateAccount(string accountName, 
            string emailAddress, TypeOfAccounts accountType)
        {
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType
            };
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public static IEnumerable<Account> GetAccounts()
        {
            return db.Accounts;
        }

        public static void Deposit(int accountNumber, decimal amount)
        {
            //Locate the account
            //LINQ
            var account = db.Accounts.SingleOrDefault(account => account.AccountNumber == accountNumber);

            if (account == null)
            {
                Console.WriteLine("Account number is invalid!");
                return;
            }
            //Deposit on the account
            
            account.Deposit(amount);
            //add a transaction
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                Description = "Branch deposit",
                Amount = amount,
                TransactionType = TypeOfTransaction.Credit,
                AccountNumber = accountNumber
            };
            db.Transactions.Add(transaction);
            db.SaveChanges();
            Console.WriteLine("Deposit successfully completed!");
        }
    }
}
