using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankApp
{
    class Transaction
    {
        //Fields
        private double _sum;
        private DateTime _timestamp;

        //Constructor
        public Transaction(double sum, DateTime timestamp)
        {
            Sum = sum;
            _timestamp = timestamp;
        }

        public double Sum { get => _sum; set => _sum = value; }

        //private void Transaction()
        //{
    }
}
