using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        BreathingChoice breathingChoice = new BreathingChoice();
        ReflectingChoice reflectingChoice = new ReflectingChoice();
        ListingChoice listingChoice = new ListingChoice();

        while(isRunning)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please pick an activity from the following options below, each one will help benefit your well being. (Except choosing #4 first, don't be a quitter.)");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter your choice: ");
            
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Let's do a breathing activity!");
                        breathingChoice.Choice1();
                    break;
                case "2":
                    Console.WriteLine("Let's do a reflecting activity!");
                        reflectingChoice.Choice2();
                    break;
                case "3":
                    Console.WriteLine("Let's do a listing activity!");
                        listingChoice.Choice3();
                    break;
                case "4":
                    Console.WriteLine("Time to go? See you again soon!");
                        // activityChoice.Choice4();
                    break;
                default:
                    Console.WriteLine("That is not a valid choice, try again.");
                    continue;
            }
            
            // Console.WriteLine("Hello Develop04 World!");
            // Console.WriteLine(5);
            // Thread.Sleep(1000);
            // Console.WriteLine(4);
            // Thread.Sleep(1000);
            // Console.WriteLine(3);
            // Thread.Sleep(1000);
            // Console.WriteLine(2);
            // Thread.Sleep(1000);
            // Console.WriteLine(1);
            // Thread.Sleep(1000);

            // for (int i=5; i>0; i--)
            // {
            //     Console.Write(i);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }

            // for (int i=5; i>0; i--)
            // {
            //     Console.Write(".");
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }

            // |/-\|/-\|
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            
            // foreach (string s in animationStrings)
            // {
            //     Console.Write(s);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10);

            while (DateTime.Now < endTime)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Done.");

            Console.WriteLine("Press any key to start over.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}