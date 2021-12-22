using System;
using System.Linq;
using System.IO;

namespace SanjjeevWorkouts
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("test.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i<=10; i++)
            {
                f.WriteByte((byte)i);
            }

            f.Position = 0;

            for (int i = 0; i<=10; i++)
            {
                Console.Write(f.ReadByte() + " ");
            }

            f.Close();

            Console.ReadKey();
        }
    }
}