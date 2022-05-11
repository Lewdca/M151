using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // Context
    public class Investment
    {
        private readonly double investmentMoney;
        private bool talkedToBankEmployee = false;
        private IInvestmentStrategy investmentStrategy;

        public Investment(double investmentMoney)
        {
            this.investmentMoney = investmentMoney;
        }

        public void SetInvestmentStrategy(IInvestmentStrategy strategy)
        {
            this.investmentStrategy = strategy;
            Console.WriteLine("Die Strategie wurde geändert");
        }

        public void TalkToBanlEmployee()
        {
            talkedToBankEmployee = true;
            Console.WriteLine("Das Beratungsgespräch wurde durchgeführt");
        }

        // In dieser Methode wird der Algorithmus für das gewählte Investment-Produkt ausgeführt.
        public void MakeInvestment()
        {
            if (investmentStrategy != null && talkedToBankEmployee == true)
            {
                investmentStrategy.Invest(investmentMoney);
            }
            else
            {
                Console.WriteLine("Die Kriterien für ein Investment wurden noch nicht erfüllt");
            }
        }
    }
}
