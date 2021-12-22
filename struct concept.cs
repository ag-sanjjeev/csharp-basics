/*
 * Struct concept and it is similar to enum but it act as class property to create multiple instance variable to hold data
 * 
 * */

using System;
using System.Linq;

namespace SanjjeevWorkouts
{

    struct Mobile
    {
        public string name;
        public string color;
        public double price;

        public void display()
        {
            Console.WriteLine("Mobile details is : \n\tname : {0}\n\tcolor : {1}\n\tprice : {2}", name, color, price);
        }
    };

    public class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile1 = new Mobile();
            Mobile mobile2 = new Mobile();
            mobile1.name = "Samsung";
            mobile1.color = "Blue";
            mobile1.price = 12000;

            mobile2.name = "realme";
            mobile2.color = "Yellow";
            mobile2.price = 15000;




            mobile1.display();
            mobile2.display();

            Console.ReadKey();
        }
    }


}