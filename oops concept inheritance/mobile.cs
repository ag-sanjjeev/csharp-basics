using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
 * Class with prefix sealed cant be inherit and gives an error *
 * ex: sealed class ClassName { ... }                          *
 ***************************************************************/

namespace Device
{
    class mobile : device
    {
        private double price;
        public double Price
        {
            get; set;
        }

        public bool setMobileDetails(string name, string color, double price)
        {
            this.Name = name;
            this.Color = color;
            this.Price = price;

            return true;
        } 

        public string getMobileDetails()
        {
            string result;

            result = $"Device Name is : {this.Name}, Color is : {this.Color} and Price is : {Convert.ToString(this.Price)}";

            return result;
        }
    }
}
