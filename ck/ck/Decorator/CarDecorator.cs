using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Decorator
{
    public abstract class CarDecorator:IDecorator
    {
        protected IDecorator decorator;
        public CarDecorator(IDecorator decorator)
        {
            this.decorator = decorator;
        }

        public virtual string name()
        {
            return decorator.name();
        }
    }
}
