using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication
{ 
    /// <summary>
    /// This class defines a Customer
    /// </summary>
    public class Customer
    {
        #region Properties

        /// <summary>
        /// Customer Id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Customer Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Customer EmailAddress
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Customer Address
        /// </summary>
        public string Address { get; set; }

        #endregion

    }
}
