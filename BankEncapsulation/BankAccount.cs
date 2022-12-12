using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccountClass
    {
        private double _balance = 0;

        //public BankAccountClass(Func<string> value)
        //{
        //}

        //public BankAccountClass()
        //{
        //    var VarCheckingBal = new BankAccountClass();
        //    var VarDeposit = new BankAccountClass();
        //}

       // public BankAccountClass(double amount)
       // {
        //    _balance = amount = 0;
       // }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        //public void Deposit(decimal amount)
       // {
       //     
        //   _balance = (double)+amount;
        //}

        public double GetBalance()
        {
            return _balance;
        }




    }
}


//Create a new public class named BankAccount
//In your BankAccount class, create the following:
//        A private field of type double named balance with a value of 0
//        Define a method named Deposit that will accept a double and store that value in the balance field
//        Define a method named GetBalance that will return the amount stored in the balance field 
//    In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
//    Once finished save, commit, and push back to Github