// methods concepts

using System;
using System.Linq;

namespace MyProject {

	class Methods {
    	
        // static keyword used to mention this is not object
        static void myMethod () { 
        	
            Console.WriteLine("This is executed");
        	
        }
        
        static void fullname(string fname, string lname) {
        	
            Console.WriteLine("Your full name is : " + fname + " " + lname);
        
        }
        
        static double add(double[] values) {
        	
            double result = 0D;
            
            foreach (double i in values) {
            	
                result += i;
            	
            }
            
            return result;
        
        }
        
        static void Main(string[] args) {
        
			myMethod();
            
            fullname(lname: "SANJJEEV", fname: "AG"); // named arguments
            
            double[] values = {1.23D, 3.45D, 44.56D};
            
            double result = add(values);
            Console.WriteLine("Sum of array of double numbers : ");
            Console.WriteLine(result);
        
        }
    
    }

}