using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Properties
        public decimal Saldo { get; private set; }
        public string Name { get; }
    
        //Constructor
        public BankAccount(string name, decimal balance)
        {
            Saldo = balance;
            Name = name;
        }
        //Methods
        public void MakeDeposit(decimal amount)
        {
            Saldo += amount;
        }
        public void MakeWithdrawal(decimal amount)
        {
           if (amount > Saldo)           
                Console.WriteLine("Insufficient funds, transaction" +
                    " failed");           
           else
                Saldo -= amount;           
        }
        public void MakeTransfer(decimal transferSum, BankAccount acc)
        { 
            MakeWithdrawal(transferSum);                         
            acc.MakeDeposit(transferSum);
        }
      
    }  
}
