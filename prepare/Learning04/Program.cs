using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Bob Jones", "Division");
        Console.WriteLine(a1.GetSummary());
        MathAssignment a2 = new MathAssignment("Tina Ray", "Exponents", "3.1", "5-9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        WritingAssignment a3 = new WritingAssignment("Nina Dukes", "Woodworking", "Lathe tools");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}