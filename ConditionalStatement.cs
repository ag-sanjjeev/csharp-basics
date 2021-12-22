using System;

namespace MyProject
{
  class ConditionalStatement
  {
    static void Main(string[] args)
    {
      int age = 24;
      
      if (age > 18 ) {
      
      	Console.WriteLine("You\'re eligible to vote");
      	
      }
      
      int hour = 12;
      
      if (hour < 10) {
      
      	Console.WriteLine("Good Morning");
      
      } else if (hour < 15) {
      
      	Console.WriteLine("Good Afternoon");
      	
      } else {
      
      	Console.WriteLine("Good Night");
      
      }
      
      string msg = ( age > 18 ) ? "You\'re eligible to vote" : "You\'re not eligible to vote";
      
      Console.WriteLine(msg);
      
      string dayTime = "morning";
      
      switch(dayTime) {
      
      	case "morning" : Console.WriteLine("Good Morning");
        break;
        
        case "afternoon" : Console.WriteLine("Good After Noon");
        break;
        
        case "evening" : Console.WriteLine("Good Evening");
        break;
        
        case "night" : Console.WriteLine("Good Night");
        break;
        
        default: Console.WriteLine("Good Day");
        break;
      
      
      }
      
    }
  }
}