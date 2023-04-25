using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Observer
{
    public class Customer : Observer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public override void ObserverInfo(string info)
        {
            MessageBox.Show("Thông báo tới khách hàng: " + Name + " Số điện thoại là: " + PhoneNumber + " Thông tin sản phẩm: " + info);
        }
        public Customer(string name, string phone)
        {
            this.Name = name;
            this.PhoneNumber = phone;
        }

    }
}
