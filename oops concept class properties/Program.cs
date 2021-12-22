using System;
using System.Linq;

namespace SanjjeevWorkouts
{

    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Person obj = new Person();

            obj.Name = name;
            obj.Age = age;
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);

            Console.ReadKey();
        }
    }

}