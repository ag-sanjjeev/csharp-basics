using System;
using System.Linq;
using Fruits;


namespace SanjjeevWorkouts
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            apple obj = new apple();
            Console.WriteLine("Enter the fruit price:\n");
            double price = Convert.ToDouble(Console.ReadLine());
            string result;
            obj.setPrice(price);
            result = obj.getPrice();
            Console.WriteLine(result);

            Console.ReadKey();
        }

    }

}