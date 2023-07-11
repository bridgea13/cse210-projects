using System.Text.Json;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

internal class Journal
{
    List <Entry>entries;
    String filePath;

    public Journal()
    {
      entries = new List <Entry>();
      filePath = "entries.json";

    }
    // Add entry
    public void add_entry()
    {
        Entry entry = new Entry();
        entry.add_response();
        entries.Add(entry);
       


    }
    //Display journal 
    public void display_entry()
    {
        
        foreach (Entry passage in entries)
        {
            Console.WriteLine("");
            passage.output_entry();
        }
    }

    //Save to file
    public void save_entry()
    {
        Console.WriteLine(entries.Count);

        string json = System.Text.Json.JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
        File.WriteAllText(filePath, json);
        Console.WriteLine("List of entries saved to file: " + filePath);
    }

    //Load journal from file
    public void load_entry()
    {
        
        String jsonData = File.ReadAllText(filePath);
        Console.WriteLine(jsonData);
        Console.ReadLine();
        entries = JsonConvert.DeserializeObject<List<Entry>>(jsonData);

        Console.WriteLine("Your journal is being loaded.");
    }
}