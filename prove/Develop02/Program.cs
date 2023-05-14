using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    //string myJournal = "myJournal.txt";//
    

    {
        //System.IO.StreamWriter// 
        Journal myJournal = new Journal();
        Entry newEntry;
        using (StreamWriter outputFile = new StreamWriter(myJournal))

        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your choice (1-5): ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                newEntry = new Entry(); newEntry.RecieveInput();
                myJournal.AddEntry(newEntry);
                break;
            case 2:
                Console.WriteLine("You selected Option 2");
                break;
            case 3:
                Console.WriteLine("You selected Option 3");
                break;
            case 4:
                Console.WriteLine("Exiting the program...");
                break;
            case 5:
                Console.WriteLine("Exiting the program...");
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }


        
        
    }
}


