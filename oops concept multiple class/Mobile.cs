using System;
using System.Linq;

namespace Devices
{


    public class Mobile
    {
        public string brand, color, result;
        public double price;

        public string getDetails()
        {
            result = $"{this.brand} Mobile color is : {this.color} and price is : {this.price}";
            return result;
        }
    }

}