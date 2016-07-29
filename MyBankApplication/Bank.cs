using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication
{

    public enum AccountTypes
    {
        Checking = 1,
        Savings = 2,
        CD = 4,
        Loan = 8
    }

    public static class Bank
   {
      

        #region Properties
        public static string Name { get; set; }
        #endregion

        #region Methods

        public static Customer CreateCustomer(string name, string emailAddress, string address)
        {
            var customer = new Customer {
                Name = name,
                EmailAddress = emailAddress,
                Address = address
                };

            var db = new BankModel();
            db.Customers.Add(customer);
            db.SaveChanges();
            db.Dispose();
            

            CreateAccount("Default Checking Account", AccountTypes.Checking, customer);

            return customer;
        }

        public static Account CreateAccount(string accountName, AccountTypes typeOfAccount, Customer customer)
        {
            var acccount = new Account
            {
                Name = accountName,
                TypeOfAccount = typeOfAccount,
                Customer = customer
            };

            var db = new BankModel();
            db.Accounts.Add(acccount);
            db.SaveChanges();
            db.Dispose();

            return acccount;
        }

        public static IEnumerable<Account> GetAllAccountsByCustomerEmail(string emailAddress)
        {
            var db = new BankModel();
            var customer  = db.Customers.Where(c => c.EmailAddress == emailAddress).FirstOrDefault();
            if (customer == null)
                return null;
            return db.Accounts.Where(a => a.Customer.Id == customer.Id);
            
        }
        #endregion
    }
}
