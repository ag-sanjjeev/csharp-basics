using System;

namespace MyProject {

	class Typecasting {
    
    
    	static void Main(string[] args) {
        
        	int a = 5;
            double b = a; // Implicit type casting
            Console.WriteLine(b);
            
            double c = 12.35;
            int d = (int) c; // Explicit type casting
            Console.WriteLine(d);
            
            /************************
             * Type casting Methods *
			 ************************/
             
            Console.WriteLine(Convert.ToString(a)); 
            Console.WriteLine(Convert.ToInt32(c));
            Console.WriteLine(Convert.ToDouble(d));
            Console.WriteLine(Convert.ToBoolean(b));
        	
        }
    
    }


}