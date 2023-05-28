

using System;
using System.IO;
public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference()
    {
        Console.WriteLine("What is the name of the book?");
        _book = Console.ReadLine();  
        Console.WriteLine("What is the chapter number?");  
        _chapter = Console.ReadLine();
        Console.WriteLine("What is the beginning verse number?");  
        _verse = Console.ReadLine();
        Console.WriteLine("What is the ending verse number?");  
        _endVerse = Console.ReadLine();
          
        
    }   
    public string GetBook(){
        return _book;
    }
    
}