using System;
using Task_exception_handling;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var account = new Account("Shiva", 150);
            try
            {
                account.Debit(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception \nException Message: " + ex.Message);
                Console.WriteLine("Account Balance: " + ex.AccountBalance);
                Console.WriteLine("Transaction Amount: " + ex.TransactionAmount);
            }

            Console.Read();
        }
    }
}