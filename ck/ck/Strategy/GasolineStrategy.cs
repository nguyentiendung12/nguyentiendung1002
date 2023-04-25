using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Strategy
{
    public class GasolineStrategy : IStrategy
    {
        public float maxCapacity()
        {
            return 100;
        }
    }
}
