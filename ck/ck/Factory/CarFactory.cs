using CuoiKy_DP.DataObject.Colors;
using CuoiKy_DP.DataObject.Produce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Factory
{
    internal class CarFactory
    {
        public Car createCar(WheelType wheelType, EngineType engineType, ColorType colorType, GearBoxType gearType, ModelType modelCarType, float maxFuelCapacity, float fuelCapacity, CarType carType, string recommentGas = null)
        {
            Wheel wheel = (Wheel)ElectricCarBuilder.electricCar.wheel.Clone();
            switch (wheelType)
            {
                case WheelType.DTDModel01_26:
                    wheel.size = 26;
                    wheel.tireMaterial = "Rubber";
                    wheel.boneMaterial = "Aluminum";

                    break;
                case WheelType.DTDModel01_27:
                    wheel.size = 27;
                    wheel.tireMaterial = "Rubber";
                    wheel.boneMaterial = "Carbon";

                    break;
                case WheelType.DTDModel01_29:
                    wheel.size = 29;
                    wheel.tireMaterial = "Rubber";
                    wheel.boneMaterial = "Aluminum";

                    break;
            }

            Engine engine = (Engine)ElectricCarBuilder.electricCar.engine.Clone();
            switch (engineType)
            {
                case EngineType.EEngine01:
                    engine.horsePower = 80;
                    engine.nameEngine = "DTDFast01E";
                    engine.version = "1.0";
                    break;
                case EngineType.EEngine02:
                    engine.horsePower = 120;
                    engine.nameEngine = "DTDFast02E";
                    engine.version = "1.1";
                    break;
                case EngineType.DEngine01:
                    engine.horsePower = 100;
                    engine.nameEngine = "DTDFast01D";
                    engine.version = "1.0";
                    break;
                case EngineType.DEngine02:
                    engine.horsePower = 150;
                    engine.nameEngine = "DTDFast02D";
                    engine.version = "1.1";
                    break;
                case EngineType.GEngine01:
                    engine.horsePower = 90;
                    engine.nameEngine = "DTDFast01G";
                    engine.version = "1.0";
                    break;
                case EngineType.GEngine02:
                    engine.horsePower = 120;
                    engine.nameEngine = "DTDFast02G";
                    engine.version = "1.1";
                    break;
            }


            string gearBox = ElectricCarBuilder.electricCar.gearBox;
            switch (gearType)
            {
                case GearBoxType.Manual:
                    gearBox = "Manual";
                    break;
                case GearBoxType.Automatic:
                    gearBox = "Automatic";
                    break;
            }

            string modelCar = ElectricCarBuilder.electricCar.modelCar;
            switch (modelCarType)
            {
                case ModelType.Sedan:
                    modelCar = "Sedan";
                    break;
                case ModelType.SUV:
                    modelCar = "SUV";
                    break;
                case ModelType.Sport:
                    modelCar = "Sport";
                    break;
                case ModelType.Hatchback:
                    modelCar = "Hatchback";
                    break;
            }

            CarColor color = new WhiteColor();
            switch (colorType)
            {
                case ColorType.White:
                    color = new WhiteColor();
                    break;
                case ColorType.Blue:
                    color = new BlueColor();
                    break;
                case ColorType.Black:
                    color = new BlackColor();
                    break;
                case ColorType.Green:
                    color = new GreenColor();
                    break;
                case ColorType.Red:
                    color = new RedColor();
                    break;
            }

            switch (carType)
            {
                case CarType.Diesel:
                    DieselCarBuilder dCarBuilder = new DieselCarBuilder();
                    dCarBuilder.setWheel(wheel);
                    dCarBuilder.setEngine(engine);
                    dCarBuilder.setColor(color);
                    dCarBuilder.setGear(gearBox);
                    dCarBuilder.setModel(modelCar);
                    dCarBuilder.setMaxTankVolume(maxFuelCapacity);
                    dCarBuilder.setFuelTankeVolume(fuelCapacity);
                    dCarBuilder.setRecommentGas(recommentGas);

                    return dCarBuilder.BuildCar();
                //break;
                case CarType.Electric:
                    ElectricCarBuilder eCarBuilder = new ElectricCarBuilder();
                    eCarBuilder.setWheel(wheel);
                    eCarBuilder.setEngine(engine);
                    eCarBuilder.setColor(color);
                    eCarBuilder.setGear(gearBox);
                    eCarBuilder.setModel(modelCar);
                    eCarBuilder.setMaxBetteryCapacity(maxFuelCapacity);
                    eCarBuilder.setBetteryCapacity(fuelCapacity);

                    return eCarBuilder.BuildCar();
                //break;
                case CarType.Gasoline:
                    GasolineCarBuilder gCarBuilder = new GasolineCarBuilder();
                    gCarBuilder.setWheel(wheel);
                    gCarBuilder.setEngine(engine);
                    gCarBuilder.setColor(color);
                    gCarBuilder.setGear(gearBox);
                    gCarBuilder.setModel(modelCar);
                    gCarBuilder.setMaxTankVolume(maxFuelCapacity);
                    gCarBuilder.setFuelTankeVolume(fuelCapacity);
                    gCarBuilder.setRecommentGas(recommentGas);

                    return gCarBuilder.BuildCar();
                    //break;
            }
            return null;
        }
    }
}