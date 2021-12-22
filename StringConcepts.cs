// String Concepts

using System;


namespace MyProject {


	class StringConcepts {
    
    
    	static void Main(string[] args) {
        
        	
            string a = "test";
        
        	// string length
            Console.WriteLine(a.Length);
            
            string f_name = "Sanjjeev";
            string l_name = "AG";
            
            // string concatenation            
            string name = "Your name is : " + f_name + " " + l_name;
            Console.WriteLine(name);
            
            
            // string concatenation method
            name = String.Concat(f_name, " ", l_name);
            Console.WriteLine(name);
            
            // string concatenation by string interpolation
            name = $"Your name is : {f_name} {l_name}";
            Console.WriteLine(name);
            
            // string methods 
            Console.WriteLine(f_name.ToUpper());
            Console.WriteLine(l_name.ToLower());
            
            // string access
            Console.WriteLine(f_name[1]);
            
            // special characters
            string text = $"It\'s your day\t{f_name}";
            Console.WriteLine(text);
        
        }
    
    }


}