
    class Prompt
    {
    string prompt;
    public Prompt()
        {
        
        Random rnd = new Random();
        

        List<string> items = new List<string>
            {
                "What was the peak of your day?",
                "What was the valley of your day?",
                "If you could re-do anything today, what would it be?",
                "What is something from today that you wished happened everyday?",
                "What are the three most grateful items from today?"
            };
        Console.Clear();
        int num = rnd.Next(items.Count);
        prompt = items[num];
        
        
        }
    

    

    public string get_prompt()
    {
        return prompt;
    }
    

        
    }

