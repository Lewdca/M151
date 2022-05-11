using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // ConcreteStrategy2
    public class CryptoInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            // Algorithmus würde hier implementiert werden.
            Console.WriteLine("Sie haben " + investMoney + " Franken in Kryptowährungen investiert.");
        }
    }
}
