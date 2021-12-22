using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Sanjjeev      AG";
            string pattern = "\\s+";
            string replacement = " ";


            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Text before replacing : {0}", input);
            Console.WriteLine("Text after replacing extra whitespace : {0}", result);

            Console.ReadKey();
        }
    }
}