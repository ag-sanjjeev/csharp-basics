// loopings

using System;

namespace MyProject {

	class Loops {
    
    	
        static void Main(string[] args) {
        	
            int i = 0;
            // While Loop
            while (i < 10) {
            	
                Console.WriteLine(i++);
            
            }
            
            i = 1;
            int j = 5;
            string result = "";
            
            // Do While Loop
            do {
            	result = $"{i} * {j} = {i * j}";
                Console.WriteLine(result);
                i++;
            
            } while (i <= 10);
            
            // For Loop
            j = 6;
            for (int k = 1; k <= 10; k++) {
            	result = $"{k} * {j} = {k * j}";
                Console.WriteLine(result);
            
            }
            
            // pattern up triangle
            
            for (i=0; i<5; i++) {
            
            	for (int k=5; k>i; k--) {
                	
                    Console.Write(' ');
                
                }
            
            	for (j=0; j<=i*2; j++) {
                
                	Console.Write('*');
                
                }
                
                for (int l=5; l>i; l--) {
                	
                    Console.Write(' ');
                
                }
                
                Console.WriteLine();
            
            
            }
            
            // pattern down triangle
            
            for (i=5; i>0; i--) {
            
            	for (int k=5; k>i; k--) {
                	
                    Console.Write(' ');
                
                }
            
            	for (j=i*2; j>0; j--) {
                
                	Console.Write('*');
                
                }
                
                for (int l=5; l>i; l--) {
                	
                    Console.Write(' ');
                
                }
                
                Console.WriteLine();
            
            
            }
            
        
        }
    
    
    }



}