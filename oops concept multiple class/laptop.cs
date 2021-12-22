using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class laptop
    {
        public string brand, color;
        public double price;

        public laptop(string brand, string color, double price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
            Console.WriteLine("Laptop class initiated");
        }

        public void displayDetails()
        {
            string result = $"{this.brand} color is : {this.color} and price is : {this.price} \n";
            Console.WriteLine(result);
        }

    }
}
