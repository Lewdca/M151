using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // Strategy
    public interface IInvestmentStrategy
    {
        void Invest(double investMoney);
    }
}
