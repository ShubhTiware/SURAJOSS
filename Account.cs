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
  public double salary {get;set:}
        //Step 2
        //shubham
        public EventHandler UnderBalance;
        public EventHandler OverBalance;
     
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result < 5000)
            {
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
