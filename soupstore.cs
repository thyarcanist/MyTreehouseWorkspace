  
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
  
  
   static double Price(int quantity)
    {
         double pricePerUnit;
         if (quantity >= 100)
         {
               pricePerUnit = 1.35;
         }
         else if  (quantity >= 50)
         {
               pricePerUnit = 1.75;
         }
         else
         {
               pricePerUnit = 2;
         }
      
        return quantity * pricePerUnit;
    }
   
   static void DiscountCheck(int totalNumber) {
      
         if (canCount < 54) 
        {
            Console.WriteLine($"For {canCount} amount of cans, you will not have the discount.");
        }
        else if (canCount >= 55 && canCount < 99) 
        {
            Console.WriteLine($"For {canCount} amount of cans , you will have the discount.");
        }
        else if (canCount >= 100) 
        {
            Console.WriteLine($"For {canCount} amount of cans, you will have the PREMIER discount.");
        }
   }
    
  
      static void Main(string[] args)
    {
        Wait();
        
        Console.WriteLine("Welcome to the Soup Store!");
        string entry = Ask("How many soup cans are you ordering? ");
       
        Console.WriteLine($"You entered {entry} cans.");
        
        int canCount = int.Parse(entry);
        double total = Price(number);
        int canCount = DiscountCheck(int.Parse(entry);
        Console.WriteLine($"For {entry} cans, you total is: ${total}");
        
    }
}
