using System;
using System.Linq;
using Devices;

namespace SanjjeevWorkouts
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Mobile obj = new Mobile();
            laptop obj2 = new laptop(brand: "Acer", color: "Blue", price: 56000D);

            obj.brand = "samsung";
            obj.color = "blue";
            obj.price = 12000D;

            string result = obj.getDetails();

            Console.WriteLine(result);
            obj2.displayDetails();

            Console.ReadKey();
        }

    }

}