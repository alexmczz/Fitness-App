using System;

namespace Alex.FitnessMin
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;
            while(true)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type q to exit: ");
                var entry = Console.ReadLine();        

                if(entry.ToLower() == "q")
                {
                    break;
                }
                
                try
                {
                    // Add minutes exercised to total 
                    var minutes = double.Parse(entry);

                    if(minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is an Invalid input");
                        continue;
                    }
                    else if(minutes <= 10)
                    {
                        Console.WriteLine("Good Job");
                    }
                    else if(minutes <= 30)
                    {
                        Console.WriteLine("Keep It Going!");
                    }
                    else if(minutes <= 60)
                    {
                        Console.WriteLine("Wow Awesome!");
                    }
                    else
                    {        
                        Console.WriteLine("Amazing!");
                    }

                    runningTotal+= minutes;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ivalid input.");
                    continue;
                }

                // Display total minutes exercised to the screen 
                Console.WriteLine("You've entered " + runningTotal + " minutes.");
            
                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");
        }
    }
}