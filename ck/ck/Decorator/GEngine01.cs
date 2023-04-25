using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Decorator
{
    public class GEngine01:CarDecorator
    {
        public GEngine01(IDecorator decorator) : base(decorator)
        {
        }
        public override string name()
        {
            addEngine();
            return base.name()+ addEngine();
        }
        public string addEngine()
        {
            
                return "GEngine01";
            
        }
    }
}
