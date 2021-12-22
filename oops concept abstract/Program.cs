using System;
using System.Linq;
using Devices;

namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter brand name :\n");
            string brand = Console.ReadLine();
            mobile obj = new mobile();
            obj.setBrand(brand);
            obj.getBrand();

            Console.ReadKey();
        }
    }
}