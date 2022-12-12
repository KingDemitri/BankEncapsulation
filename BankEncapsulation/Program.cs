using System.Security.Principal;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.ForegroundColor = ConsoleColor.White;
            //-Console.WriteLine(VarChecking.ToString());
            //Console.WriteLine(VarDepositAmt.ToString());
            /////////////////NOT IMPORTANT///////////////////
            ////////I wanted to play around with this////////

            Console.WriteLine("Welcome to this authorized *RealBank* ATM");
            Console.WriteLine("Press anything to continue");
            Console.ReadLine();


            BankAccountClass varCheckingBal = new BankAccountClass();

            double currentBal = varCheckingBal.GetBalance();

            Console.WriteLine($"Your Balance is currently ${currentBal}");
            //var VarCheckingBal = new BankAccountClass()// => Console.WriteLine("Balance"));

            Console.WriteLine("How much are you depositing today?");
            double varDepositAmt = double.Parse(Console.ReadLine());
            //var VarDepositAmt = new BankAccountClass(() => Console.ReadLine());
            varCheckingBal.Deposit(varDepositAmt);
            varCheckingBal.GetBalance();

            Console.WriteLine($"New Balance:\n{varCheckingBal.GetBalance()}");
            

            Console.WriteLine("Thank You For Choosing *RealBank* \nGoodbye");
            //-Console.WriteLine(VarChecking.ToString());
            
        }
    }
}





//Create a new public class named BankAccount
//    In the main method of your application, create a new instance of the BankAccount class.
//    Allow the user of the application to Deposit money and retrieve their balance through the console.
//    Once finished save, commit, and push back to Github