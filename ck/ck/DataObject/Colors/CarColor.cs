using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Colors
{
    public abstract class CarColor : ICloneable
    {
        public string hexCode { get; set; }
        public string colorName { get; set; }

        public object Clone()
        {
            return (CarColor)this.MemberwiseClone();
        }
    }
}