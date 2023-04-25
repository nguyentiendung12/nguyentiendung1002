using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Strategy
{
    public class DieselStrategy : IStrategy
    {
        public float maxCapacity()
        {
            return 70;
        }
    }
}
