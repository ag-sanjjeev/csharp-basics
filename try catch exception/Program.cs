/*
 * Try catch and exception
 *
 * */

using System;
using System.Linq;

namespace SanjjeevWorkouts
{
   public class Program
   {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have entered correctly...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
   }
}