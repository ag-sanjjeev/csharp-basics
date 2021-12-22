using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class mobile : devices
    {
        private string brand;
        public string Brand
        {
            get; set;
        }

        public void displayBrand()
        {
            string result = $"The mobile name : {this.Brand}";
            Console.WriteLine(result);
        }
    }
}
