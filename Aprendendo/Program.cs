using System;
using Aprendendo.Entities.Exceptions;

namespace Aprendendo.Entities
    
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());


                Account account = new Account(number, holder, balance, 500);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance.ToString("f2"));
            }

            catch (DomainException ex)
            {
                Console.WriteLine("Withdraw error: " + ex.Message);
            }

        }
    }
}