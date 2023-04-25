using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Strategy
{
    public class ElectricStrategy : IStrategy
    {
        public float maxCapacity()
        {
            return 90;
        }
    }
}
