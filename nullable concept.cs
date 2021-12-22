/*
 * Nullable concept in c#
 * */

using System;
using System.Linq;

namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = 45;

            double? c = new double?();
            double? d = 45.65;

            bool? e = new Boolean?();

            Console.WriteLine("Nullable and actual values are : {0}, {1}, {2} and {3}", a, b, c, d);
            Console.WriteLine("Nullable boolean value is : {0}", e);

            Console.ReadKey();
        }
    }
}