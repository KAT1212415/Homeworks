using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount Account = new BankAccount();
            BankAccount Account2 = new BankAccount();

            Account.Deposit(100);
            Account2.Deposit(3200);
            Account2.DepositWithdraw(3300);

            Console.WriteLine($"Номер счета{Account.AccountNumber},баланс {Account._balance}");
            Console.WriteLine($"Номер счета{Account2.AccountNumber},баланс {Account2._balance} всего счетов {BankAccount.TotalAccount}");

        }
    }
    internal class BankAccount
    {
        
        //private string _name;
        public static int TotalAccount { get; set; }
        public int AccountNumber { get; }
        public decimal _balance { get; set; }
       

        static BankAccount()
        {
            TotalAccount = 0;           
        }

        public BankAccount()

        {   
            Random rnd = new Random();
            AccountNumber = rnd.Next(1000,9999);
            TotalAccount++;
            _balance = 0;
        }

        public decimal Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance = _balance + amount;
            }
            
            return _balance;
        }
        public decimal DepositWithdraw(decimal amount)
        {                     
            if (_balance < amount)
             throw new Exception($"Сумма снятия больше чем баланс счета" +
                 $" введите сумму меньше {_balance}");

            _balance = _balance - amount;
            return _balance;
        }
    }
}
