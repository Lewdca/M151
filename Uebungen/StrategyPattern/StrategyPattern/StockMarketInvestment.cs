using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class StockMarketInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            // Algorithmus würde hier implementiert werden.
            Console.WriteLine("Sie haben " + investMoney + " Franken in Aktien investiert.");
        }
    }
}
