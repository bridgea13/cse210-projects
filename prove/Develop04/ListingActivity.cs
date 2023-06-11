class ListingChoice
{
    public void Choice3()
    {
        Console.WriteLine("This breathing activity is great for relaxation and focus. Choose how many seconds you would like to participate in this activity.");
        Console.WriteLine("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine($"Starting countdown");

            for (int i = duration; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Done.");
        }
        else
        {
            Console.WriteLine("Duration is not valid, try again.");
        }
    }
}