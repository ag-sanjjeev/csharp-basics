using System;
using System.Linq;
using Device;

namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to devices");

            Console.WriteLine("\nEnter device name :");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter device color :");
            string color = Console.ReadLine();

            Console.WriteLine("\nEnter device price :");
            double price = Convert.ToDouble(Console.ReadLine());

            mobile obj = new mobile();
            obj.setMobileDetails(name: name, color: color, price: price);
            string result = obj.getMobileDetails();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}