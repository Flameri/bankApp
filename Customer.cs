using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _accountNumber;
        
        //Constructor
        public Customer(string firstName, string lastName, string accountNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            AccountNumber = accountNumber;
        }

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }

        //Override Tostring
        public override string ToString()
        {
            return ($"Etunimi {_firstName}" +
                $"Sukunimi {_lastName}" +
                $"Tilinumero {AccountNumber}");
        }
    }

}
