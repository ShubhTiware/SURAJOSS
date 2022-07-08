using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{

    //Delegates are used to define events
    //Step 1
    public delegate void EventHandler();
    internal class Account
    {
        public double Balance { get; set; }

        //Step 2
        public EventHandler UnderBalance;
        public EventHandler OverBalance;
     
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result < 5000)
            {
                //from shubham tiware
                //raise ( or trigger) event UnderBalance
                UnderBalance();  //we are calling event
            }
            else
            {
                Balance = result;
            }
        }
        public void Deposit(double amount)
        {
            double result = Balance +amount;
            if (result >= 350000)
            {
                //raise event OverBalance
                OverBalance();
            }
            else
            {
                Balance = result;
            }
        }
    }
}
