using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication
{
    public class Account
    {
        #region Variables
        //Variables are private (most of the time)
        private decimal balance;
        #endregion

        #region Static
        // Static - memory for all instances to use. We use static when we want to share instancecs
     //   private static int lastId = 0;
        #endregion

        #region Properties

        //autoproperties - backing field - if there is no code inside get or set
        /// <summary>
        /// Account Id
        /// </summary>
        [Key]
        public int Id { get; private set; }

        /// <summary>
        /// Account Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Account Balance
        /// </summary>
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if ( value >= 0)
                {
                    balance = value;
                }
            }
        }

        public virtual Customer Customer { get; set; }
        #endregion

        #region Constructor
        public Account()
        {
            // lastId = lastid + 1;
            //lastId++ -> Post increment
            //++lastId -> Pre increment
         //   Id = ++lastId;  
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into the account. Add the Amount to the Balance
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount; //Balance = Balance + amount;
        }

        /// <summary>
        /// Withdraw money from the account. Substract the amount from the balance
        /// </summary>
        /// <param name="amount">Amount to be withdrawed</param>
        public void Withdraw(decimal amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
            }
            
        }

        #endregion
    }
}
