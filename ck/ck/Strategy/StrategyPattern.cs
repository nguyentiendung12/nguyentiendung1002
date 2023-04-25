using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Strategy
{
    public class StrategyPattern
    {
        private IStrategy strategy;
        public StrategyPattern(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public float SetStrategy(IStrategy strategy)
        {
            return strategy.maxCapacity();
        }

    }
}
