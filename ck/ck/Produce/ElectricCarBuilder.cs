using CuoiKy_DP.DataObject.TypeCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_DP.DataObject.Produce
{
    internal class ElectricCarBuilder : CarBuilder
    {
        public float _MaxBatteryCapacity;
        public float _BatteryCapacity;
        public static ElectricCar electricCar = new ElectricCar();


        public void setBetteryCapacity(float batteryCapacity)
        {
            _BatteryCapacity = batteryCapacity;
        }

        public void setMaxBetteryCapacity(float batteryCapacity)
        {
            _MaxBatteryCapacity = batteryCapacity;
        }

        public override Car BuildCar()
        {
            ElectricCar ecar = (ElectricCar)electricCar.Clone();

            ecar.wheel = _wheel;
            ecar.engine = _engine;
            ecar.color = _color;
            ecar.modelCar = _modelCar;
            ecar.gearBox = _gearBox;
            ecar.maxCapacity = _MaxBatteryCapacity;
            ecar.batteryCapacity = _BatteryCapacity;

            return ecar;
        }
    }
}