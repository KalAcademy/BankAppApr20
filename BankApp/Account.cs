using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum TypeOfAccounts
    {
        Checking,
        Savings,
        CD,
        Loan
    }

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
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccounts AccountType { get; set; }
        public decimal Balance { get; private set; }
        public DateTime CreatedDate { get; private set; }
        #endregion


        #region Constructor
        public Account()
        {
            CreatedDate = DateTime.Now;
        }

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
