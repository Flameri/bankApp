using System;
using System.Collections.Generic;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("BankApp v1.0");
            Bank bank1 = new Bank("Ankkalinnan pankki");

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Aku", "Ankka", bank1.CreateAccount()));
            customers.Add(new Customer("Roope", "Ankka", bank1.CreateAccount()));
            customers.Add(new Customer("Hannu", "Hanhi", bank1.CreateAccount()));


            bank1.AddTransactionForCustomer(customers[0].AccountNumber,
                new Transaction(1234, new DateTime(2018, 02, 23)));

            PrintBalance(bank1, customers[0]);
                
            Console.WriteLine("<Enter> lopettaa!");
            Console.ReadLine();
        }
        //Asiakkaan ja tilitapahtumien tulostus

        public static void PrintBalance(Bank bank, Customer customer)
        {
            var balance = bank.GetBalanceForCustomer(customer.AccountNumber);
            Console.WriteLine("{0} - balance: {1}{2:0.00}",
                customer.ToString(), balance >= 0 ? "+" : "", balance);

            if (balance >= 0)
                Console.WriteLine($"{customer.ToString()} - balance: + {balance:C}");
            else
                Console.WriteLine($"{customer.ToString()} - balance: {balance:C}");
        }
    }
}
