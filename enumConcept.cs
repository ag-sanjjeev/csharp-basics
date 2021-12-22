/* enum is special class that represents group of constant and that are unchangeable */

using System;
using System.Linq;

namespace SanjjeevWorkouts
{
    enum PriceRange
    {
        Low,
        Medium,
        High
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default price range is : ");
            Console.WriteLine(PriceRange.Low);
            Console.ReadKey();
        }
    }
}