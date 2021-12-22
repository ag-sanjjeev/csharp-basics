using System;
using System.Linq;
using Devices;

namespace SanjjeevWorkouts
{

    public class Program
    {
        static void Main(String[] args)
        {
            devices obj1 = new devices();
            obj1.Brand = "Smart Watch";

            laptop obj2 = new laptop();
            obj2.Brand = "Acer";

            mobile obj3 = new mobile();
            obj3.Brand = "Samsung";

            /****************
             * Polymorphism *
             ****************/

            obj1.displayBrand();
            obj2.displayBrand();
            obj3.displayBrand();

            Console.ReadKey();
        }
    }

}