using System;
using System.Threading;

class Program
{
   
  static void Wait(){
      Console.WriteLine("Loading shelves...");
      Thread.Sleep(3000);
      Console.WriteLine("Applying labels...");
      Thread.Sleep(5000);
      Console.WriteLine("Stocking cans...");
      Thread.Sleep(3000);
  }
  
   static string Ask(string question)
  {
      Console.Write(question);
      return Console.ReadLine();
  }
  
  
  static void DiscountCheck(int quantity) {
      return quantity * 2; 
  }
    
  
      static void Main(string[] args)
    {
        Wait();
        
        Console.WriteLine("Welcome to the Soup Store!");
        string entry = Ask("How many soup cans are you ordering? ");
       
        Console.WriteLine($"You entered {entry} cans.");
        
        int canCount = int.Parse(entry);
        Console.WriteLine($"For {entry} cans, you total is: ${canCount * 2}");
         
        if (canCount < 74)
        {
            Console.WriteLine($"For {canCount} amount of cans, you will not have the discount.");
        }
        else if (canCount >= 75 && canCount < 99 ) 
        {
            Console.WriteLine($"For {canCount} amount of cans , you will have the discount.");
        }
        else if (canCount >= 100) 
        {
            Console.WriteLine($"For {canCount} amount of cans, you will have the PREMIER discount.");
        }
        
    }
}
