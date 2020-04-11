using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// This class represents
    /// a bank account, where you can 
    /// deposit, withdraw...
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Unique account number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        #endregion
    }
}
