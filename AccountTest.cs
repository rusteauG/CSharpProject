using AccountTest;
Account account1 = new Account("Jane's Doe",50.0M);
Account account2 = new Account("Crispy Cheese",-7.53M);
Console.WriteLine("Account1 Balance: {0,6:C}",account1.Balance);
Console.WriteLine($"{account1.Name}'s Balance: {account1.Balance,6:C}");
Console.WriteLine($"{account2.Name}'s Balance: {account2.Balance,6:C}");

decimal depositAmount;
Console.WriteLine("Enter Deposit Amount for Account1: ");
//depositAmount = Convert.ToDecimal( Console.ReadLine() ); OR
depositAmount = decimal.Parse(Console.ReadLine());
Console.WriteLine("Adding {0,6:C} to Account1 Balance\n",depositAmount);
account1.Credit(depositAmount);
Console.WriteLine("Account Balance: {0,6:C}", account1.Balance);

Console.Write("Enter Withrawal amount: ");
decimal debitAmount = decimal.Parse(Console.ReadLine());
account1.Debit(debitAmount);
Console.WriteLine();
Console.WriteLine("Account Balance: {0,6:C}", account1.Balance);

-------------------------------------
//Reading and writing monetary  amounts with acocunts objects.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace AccountTest
{
    internal class Account
    {
        private decimal balance;//Instance variable that stores balance
        public string Name {  get; set; }   
        //constructor
        public Account(string accountName,decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;    
        }

        public void Credit( decimal amount)
        { Balance = Balance+ amount; }

        public void Debit(decimal amount)
        { Balance = Balance - amount; }  
    //property to get set balance
        public decimal Balance
        {
            get { return balance; }
            private set //can be used only within the Class 
            { 
                //Validate the value is  greater  than  or  equal to 0
                if(value > 0.0m) //m indicates decimal
                balance = value;
            }
        }


    }
}
