// This is an example Project
using System;

namespace SanjjeevWorkouts {

	/**********************
     * This is main class *
     **********************/

	class Program {
    
    
    	static void Main(string[] args) {
        
        
        	Console.WriteLine("Hello World");
            
            int a = 5, b = 10;
            
            double c = 10.5;
            double d = 15.65D;
            
            char e = 'a';
            char f = 'c';            
        
        	string firstName = "Sanjjeev";
            string lastName = "Gaanth";
        	
            bool status = true;
        	
            const string greet = "Hello";
            
            float g = 23.45f;
            
            long h = 500000000000000L;
        
            // Int add
           	Console.WriteLine(a + b);
            // Float double add
            Console.WriteLine(c + d);
            
            Console.Write(e);
            Console.Write('/');
            Console.Write(f);
            Console.WriteLine();
        
        	Console.WriteLine(g);
            
            Console.WriteLine(h);
        
        	Console.WriteLine(firstName + " " + lastName);
            
            Console.WriteLine(status);
            
            Console.WriteLine(greet);
        
        }
    
    }


}