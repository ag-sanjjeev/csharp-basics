// Arrays

using System;
using System.Linq; // useful array methods

namespace MyProject {

	class ArrayConcepts {
    
    
    	static void Main(string[] args) {
        
        	
            string[] devices; // array declaration
            
            string[] mobiles = {"Samsung", "RealMe", "MicroMax", "POCO", "Apple", "Sony", "One Plus"}; // array initialization
            
            Console.WriteLine("Your mobile is : " + mobiles[0]);
            
            Console.WriteLine("\nAvailable Mobile Brands : \n");
            
            // loop through array
            for (int i = 0; i < mobiles.Length; i++) {
            
            	Console.WriteLine(mobiles[i]);
            
            }
            
            // loop through array            
            foreach (string i in mobiles) {
            	
                Console.WriteLine(i);
            
            }
            
            Console.WriteLine("\n Array before sort : \n");
            
            
            foreach (string i in mobiles) {
            	
                Console.WriteLine(i);
            	
            }
            
            // array sort
            Array.Sort(mobiles);
            
            Console.WriteLine("\nArray after sort");
            
            foreach (string i in mobiles) {
            
            	Console.WriteLine(i);
            
            }
            
            int[] numbers = {1, 5, 2, 4};
            
            // System.Linq namespace related methods
        	
            Console.WriteLine(numbers.Min()); // returns minimun value in array
            Console.WriteLine(numbers.Max()); // returns maximum value in array
            Console.WriteLine(numbers.Sum()); // returns sum of value in array
        
        }
    
    }
	




}