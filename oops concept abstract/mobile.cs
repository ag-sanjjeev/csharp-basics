using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class mobile : devices
    {
        public string brand;

        public override void setBrand(string brand)
        {
            this.brand = brand;
        }

        public override void getBrand()
        {
            string result = $"The mobile name is : {this.brand}";
            Console.WriteLine(result);
        }
    }
}
