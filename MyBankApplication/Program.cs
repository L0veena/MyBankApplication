using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Instances of the class or objects
            // //When the execution engines sees the "new", first it will go to the Account(blueprint) and create the ststic members
            // //Static is guarenteed to happen before the memory is created. 
            // //New is the keywod to fire the constructor
            // //      var account = new Account();
            // var account = new Account { Name = "Loveena" };
            //     // Properties shows in wrench icon amd method shows up in cube
            //// account.Id = 1; we does not need this code.  we made the set private
            // account.Name = "Loveena";
            // account.Deposit(400);
            // account.Withdraw(100);

            // Console.WriteLine("AccountId: {0}, Name: {1}, Balance: {2:c}", account.Id, account.Name, account.Balance);

            // var account2 = new Account();
            // account2.Name = "My Savings";
            // Console.WriteLine("AccountId: {0}, Name: {1}, Balance: {2:c}", account2.Id, account2.Name, account2.Balance);


            var c1 = Bank.CreateCustomer("Loveena", "t@test.com", "123 Main St");

            var accounts = Bank.GetAllAccountsByCustomerEmail("t@test.com");
            foreach (var account in accounts)
            {
                Console.WriteLine(account.Balance);
            }
        }
    }
}
