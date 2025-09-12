using System;

class Program
{
    static void Main()
    {
        Console.Write("Check Traffic Light signa. Enter a color:");
        string signal = Console.ReadLine();

        if (signal == "Red")
            Console.WriteLine("Stop!");
        else if (signal == "Yellow")
            Console.WriteLine("Get Ready!");
        else if (signal == "Green")
            Console.WriteLine("Go!");
        else
            Console.WriteLine("Invalid signal try again");
    }
}


// 5. შუქნიშანი (Traffic Light System)
// დავალება: დაწერე პროგრამა, რომელიც შუქნიშნის ფერს შეამოწმებს.

// Input: signal ("Red", "Yellow", "Green")
// Output:

// "Red" → "Stop!"
// "Yellow" → "Get Ready!"
// "Green" → "Go!"
// სხვა შემთხვევაში → "Invalid signal"