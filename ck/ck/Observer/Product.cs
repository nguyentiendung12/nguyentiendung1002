using ck.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck.Observer
{
    public class Product : Observer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Customer> customers = new List<Customer>();
        public override void ObserverInfo(string info)
        {
            foreach (Customer item in customers)
            {
                if (item != null)
                {
                    item.ObserverInfo(Name);
                }
            }
        }
        public Product(string name)
        {
            this.Name = name;
        }
        public void AddCustomer(Customer cus)
        {
            if (cus != null)
            {
                customers.Add(cus);
            }
        }
        public void RemoveCustomer(Customer cus)
        {
            if (cus != null)
            {
                customers.Remove(cus);
            }
        }
    }
}
