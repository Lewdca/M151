using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // ConcreteStrategy1
    public class GoldInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            // Algorithmus würde hier implementiert werden.
            Console.WriteLine("Sie haben " + investMoney + " Franken in Gold investiert.") ;
        }
    }
}
