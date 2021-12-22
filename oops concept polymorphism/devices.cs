using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class devices
    {
        private string brand;
        public string Brand
        {
            get; set;
        }

        public void displayBrand()
        {
            string result = $"The device name is {this.Brand} \n";
            Console.WriteLine(result);
        }
    }
}
