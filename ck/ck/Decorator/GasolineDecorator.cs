using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Decorator
{
    public class GasolineDecorator : IDecorator
    {
        public string name()
        {
            return "Gasoline: ";
        }
    }
}
