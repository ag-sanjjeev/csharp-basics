// OOPS concept

using System;
using System.Linq;

namespace MyProject {


	class Mobile {
    	// class properties as one of member
    	public string model;
        public string color;
        public string storage;
        //class methods as one of member
        public void displayName() {
        
        	Console.WriteLine(this.model + " " + this.color + " " + this.storage);
        
        }
        
        static void Main(string[] args) {
        
        	Mobile samsung = new Mobile();
            
            samsung.model = "f22";
            samsung.color = "blue";
            samsung.storage = "64gb";
            samsung.displayName();
            
        }
    
    }

}