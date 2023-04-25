﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject
{
    public class Wheel : ICloneable
    {
        public float size { get; set; }
        public string tireMaterial { get; set; }
        public string boneMaterial { get; set; }

        public Wheel(float size, string tireMaterial, string boneMaterial)
        {
            this.size = size;
            this.tireMaterial = tireMaterial;
            this.boneMaterial = boneMaterial;
        }


        public object Clone()
        {
            return (Wheel)this.MemberwiseClone();
        }
    }
}