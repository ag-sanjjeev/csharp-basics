#define PI
using System;
using System.Linq;

/*
 * Pre-processor directives used for run code in diferent manner such as DEBUG enabled or not OR Production environment or Test environment
 */

namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {
            #if (PI)
                Console.WriteLine("PI defined");
            #else
                Console.WriteLine("PI is not defined");
            #endif

            Console.ReadKey();
        }
    }
}