using System;
using System.Linq;
using System.IO; // This system IO namespace has file related methods

namespace SanjjeevWorkouts
{
    public class Program
    {        

        static int ChooseMenu()
        {
            string menu = $"Please select one of the option to perform\n\t1.Create File\n\t2.Read File\n\t3.Write File\n\t4.Edit File";
            Console.WriteLine(menu);
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        static string GetFileName()
        {
            string nameAsk = $"Please select one of the option to perform\n\t1.Create File\n\t2.Read File\n\t3.Write File\n\t4.Edit File";
            Console.WriteLine(nameAsk);
            string name = Convert.ToString(Console.ReadLine());
            return name;
        }

        static void fileOperation()
        {
            int choice = ChooseMenu();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have selected create file");
                    string filename = GetFileName();
                    if (filename != "")
                    {
                        filename = $"{filename}.txt"; // it will create file in current project executable directory
                        File.Create(filename).Dispose(); // It releases all resource used by stream
                        Console.WriteLine("File has created..." + filename);
                        Console.WriteLine("Do you want perform another ? Y/N");
                        char redo = Console.ReadLine()[0];

                        if (Char.ToLower(redo) == 'y')
                        {
                            fileOperation();
                        }
                        else
                        {
                            Console.WriteLine("Thankyou");
                        }
                    }

                    break;
            }

        }

        static void Main(string[] args)
        {

            fileOperation();
            Console.ReadKey();
        }

    }
}


/* 
 * Reading console character methods
    char redo = Console.ReadLine()[0]; // method 1
    char redo = Console.ReadKey().KeyChar; // method 2
    char redo = Convert.ToChar(Console.ReadLine()); // method 3

    char redo;
    bool result;
    result = Char.TryParse(Console.ReadLine(), out redo); // method 4
     */
