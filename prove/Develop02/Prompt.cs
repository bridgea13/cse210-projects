using System;
using System.IO;

public class Prompt
{
    
    {
        public string_prompt;
        Random random = new Random();

        List <string> items = new List <string>
        {
            "What was the peak of your day?",
            "What was the valley of your day?",
            "If you could re-do anything today, what would it be?",
            "What is something from today that you wished happened everyday?",
            "What are the three most grateful items from today?"
        };

        Console.WriteLine("bbbbb");
        Console.ReadKey();

        int randomIndex = random.Next(items.Count);

        
        string randomItem = items[randomIndex];

        
        Console.WriteLine(randomItem);
    }
    
}