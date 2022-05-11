using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Investment inv = new Investment(300.00);
            inv.SetInvestmentStrategy(new CryptoInvestment());
            inv.MakeInvestment();

            Console.ReadKey();
        }
    }
}
