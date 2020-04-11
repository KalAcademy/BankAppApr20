using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    static class Bank
    {
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
            return account;
        }
    }
}
