using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Customer Name
        /// </summary>
      //  [StringLength(250)]
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
