using ck.Decorator;
using ck.Observer;
using ck.Strategy;
using CuoiKy_DP.DataObject;
using CuoiKy_DP.DataObject.Factory;
using CuoiKy_DP.DataObject.Produce;
using CuoiKy_DP.DataObject.TypeCar;
using System.Security.Cryptography.X509Certificates;

namespace ck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void raddanhsach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đi đến Database?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                cosodulieu cosodulieu = new cosodulieu();
                cosodulieu.ShowDialog();
                this.Close();
            }
        }

        private void bF_Click_Click(object sender, EventArgs e)
        {
            if (radDiesel.Checked && cbDiesel.SelectedItem.ToString() == "DEngine01")
            {
                IDecorator decorator = new DieselDecorator();

                DEngine01 dEngine01 = new DEngine01(decorator);
                CarFactory carBuilder = new CarFactory();
                EngineType engineType = (EngineType)Enum.Parse(typeof(EngineType), dEngine01.addEngine());
                var ecar = carBuilder.createCar(Chon(), engineType, Color(), gear(), model(), 20000, 0, CarType.Gasoline);
                Ketqua ketqua = new Ketqua(dEngine01.name() + "+ Size: " + (ecar.wheel.size).ToString() + "+Color: " + (ecar.color.colorName).ToString() + "+Engine:" + (ecar.engine.horsePower).ToString() + "+GearBox: " + (ecar.gearBox).ToString() + "+Model Car: " + (ecar.modelCar).ToString() + "+ MaxCapacity: " + (max()).ToString());
                this.Hide();
                ketqua.ShowDialog();
                this.Close();
            }
            else if (radDiesel.Checked && cbDiesel.SelectedItem.ToString() == "DEngine02")
            {
                IDecorator decorator = new DieselDecorator();
                DEngine02 dEngine02 = new DEngine02(decorator);
                CarFactory carBuilder = new CarFactory();
                EngineType engineType = (EngineType)Enum.Parse(typeof(EngineType), dEngine02.addEngine());
                var ecar = carBuilder.createCar(Chon(),engineType , Color(), gear(), model(), 20000, 0, CarType.Gasoline);
                
                Ketqua ketqua = new Ketqua(dEngine02.name() + "+ Size:" + (ecar.wheel.size).ToString() + "+Color:" + (ecar.color.colorName).ToString() + "Engine: " + (ecar.engine.horsePower).ToString() + "+GearBox: " + (ecar.gearBox).ToString() + "+Model Car: " + (ecar.modelCar).ToString() + "+ MaxCapacity: " + (max()).ToString());
                this.Hide();
                ketqua.ShowDialog();
                this.Close();
            }
            else if (radElectric.Checked && (cbElectric.SelectedItem.ToString()) == "EEngine01")
            {
                IDecorator decorator = new ElectricDecorator();
                EEngine01 eEngine01 = new EEngine01(decorator);
                CarFactory carBuilder = new CarFactory();
                EngineType engineType = (EngineType)Enum.Parse(typeof(EngineType), eEngine01.addEngine());
                var ecar = carBuilder.createCar(Chon(), engineType, Color(), gear(), model(), 20000, 0, CarType.Gasoline);
                Ketqua ketqua = new Ketqua(eEngine01.name() + "+ Size: " + (ecar.wheel.size).ToString() + "+Color: " + (ecar.color.colorName).ToString() + "+Engine: " + (ecar.engine.horsePower).ToString() + "Gearbox: " + (ecar.gearBox).ToString() + "Model Car: " + (ecar.modelCar).ToString() + "+ MaxCapacity: " + (max()).ToString());
                this.Hide();
                ketqua.ShowDialog();
                this.Close();
            }
            else if (radElectric.Checked && (cbElectric.SelectedItem.ToString()) == "EEngine02")
            {
                IDecorator decorator = new ElectricDecorator();
                EEngine02 eEngine02 = new EEngine02(decorator);
                CarFactory carBuilder = new CarFactory();
                EngineType engineType = (EngineType)Enum.Parse(typeof(EngineType), eEngine02.addEngine());
                var ecar = carBuilder.createCar(Chon(), engineType, Color(), gear(), model(), 20000, 0, CarType.Gasoline);
                Ketqua ketqua = new Ketqua(eEngine02.name() + "+ Size: " + (ecar.wheel.size).ToString() + "+Color: " + (ecar.color.colorName).ToString() + "+Engine: " + (ecar.engine.horsePower).ToString() + "+Gearbox: " + (ecar.gearBox).ToString() + "+Model Car: " + (ecar.modelCar).ToString() + "+ MaxCapacity: " + (max()).ToString());
                this.Hide();
                ketqua.ShowDialog();
                this.Close();
            }
            else if (radGasoline.Checked && (cbGasoline.SelectedItem).ToString() == "GEngine01")
            {
                IDecorator decorator = new GasolineDecorator();
                GEngine01 gEngine01 = new GEngine01(decorator);
                
                CarFactory carBuilder = new CarFactory();
                EngineType engineType = (EngineType)Enum.Parse(typeof(EngineType), gEngine01.addEngine());
                var ecar = carBuilder.createCar(Chon(), engineType, Color(), gear(), model(), 20000, 0, CarType.Gasoline);
                Ketqua ketqua = new Ketqua(gEngine01.name() + "+ Size:" + (ecar.wheel.size).ToString() + "+Color: " + (ecar.color.colorName).ToString() + "+Engine: " + (ecar.engine.horsePower).ToString() + "+Gearbox: " + (ecar.gearBox).ToString() + "+Model Car: " + (ecar.modelCar).ToString() + "+ MaxCapacity: " + (max()).ToString());
                this.Hide();
                ketqua.ShowDialog();
                this.Close();
            }
            
            else if (radGasoline.Checked && (cbGasoline.SelectedItem).ToString() == "GEngine02")
            {
               
                IDecorator decorator = new GasolineDecorator();
                
                GEngine02 gEngine02 = new GEngine02(decorator);
                EngineType engineType = (EngineType)Enum.Parse(typeof(EngineType), gEngine02.addEngine());
                CarFactory carBuilder = new CarFactory();
                var ecar = carBuilder.createCar(Chon(), engineType, Color(), gear(), model(), max(), 0, CarType.Gasoline);
                Ketqua ketqua = new Ketqua(gEngine02.name()+"+ Size: "+(ecar.wheel.size).ToString()+"+ Color: "+(ecar.color.colorName).ToString()+"+ Engine: "+(ecar.engine.horsePower).ToString()+"+ GearBox: "+(ecar.gearBox).ToString()+"+ Model Car: "+(ecar.modelCar).ToString()+"+ MaxCapacity: "+(max()).ToString());
                this.Hide();
                ketqua.ShowDialog();
                this.Close();
            }

        }
      
        float max()
        {
            
            StrategyPattern strategyPattern = new StrategyPattern(new DieselStrategy());
            float f = 0;
            if (radDiesel.Checked)
            {
                f= strategyPattern.SetStrategy(new DieselStrategy());
                return f;
            }
            else if (radGasoline.Checked)
            {
                f= strategyPattern.SetStrategy(new GasolineStrategy());
                return f;
            }
            else if (radElectric.Checked)
            {
                f= strategyPattern.SetStrategy(new ElectricStrategy());
                return f;
            }
            return f;
        }
        WheelType Chon()
        {
            WheelType wheelType=WheelType.DTDModel01_26;
            if (radDTDModel01.Checked)
            {
                wheelType = WheelType.DTDModel01_26;
            }
            else if (radDTDModel02.Checked)
            {
                wheelType = WheelType.DTDModel01_27;
            }
            else if (radDTDModel03.Checked)
            {
                wheelType = WheelType.DTDModel01_29;
            }
            return wheelType;
        }
        ColorType Color()
        {
            ColorType colorType = ColorType.White;
            if (radGreen.Checked)
            {
                colorType = ColorType.Green;
            }
            else if (radBlue.Checked)
            {
                colorType = ColorType.Blue;
            }
            else if (radWhite.Checked)
            {
                colorType = ColorType.White;
            }
            else if (radBlack.Checked)
            {
                colorType = ColorType.Black;
            }
            else if (radRed.Checked)
            {
                colorType = ColorType.Red;
            }
            return colorType;
        }
        GearBoxType gear()
        {
            GearBoxType gearBoxType=GearBoxType.Manual;
            if (radManual.Checked)
            {
                gearBoxType= GearBoxType.Manual;
            }
            else if (radAutomatic.Checked)
            {
                gearBoxType= GearBoxType.Automatic;
            }
            return gearBoxType;
        }
        ModelType model()
        {
            ModelType modelType = ModelType.Sedan;
            if (radHatchback.Checked)
            {
                modelType = ModelType.Hatchback;
            }
            else if (radSedan.Checked)
            {
                modelType = ModelType.Sedan;
            }
            else if (radSport.Checked)
            {
                modelType = ModelType.Sport;
            }
            else if (radSUV.Checked)
            {
                modelType = ModelType.SUV;
            }
            return modelType;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnthongbao_Click(object sender, EventArgs e)
        {
            Product sanpham = new Product("Bạn có cơ hội trúng 1 phần quà đặc biệt");
            Customer cus1 = new Customer("Dũng", "079797");
            sanpham.AddCustomer(cus1);
            sanpham.ObserverInfo("");
        }

        private void cbElectric_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radElectric_CheckedChanged(object sender, EventArgs e)
        {
            cbDiesel.Enabled = false;
            cbGasoline.Enabled = false;
            cbElectric.Enabled = true;
        }

        private void radGasoline_CheckedChanged(object sender, EventArgs e)
        {
            cbDiesel.Enabled = false;
            cbGasoline.Enabled = true;
            cbElectric.Enabled = false;
        }

        private void radDiesel_CheckedChanged(object sender, EventArgs e)
        {

            cbElectric.Enabled = false;
            cbDiesel.Enabled = true;
            cbGasoline.Enabled = false;

        }
    }
}