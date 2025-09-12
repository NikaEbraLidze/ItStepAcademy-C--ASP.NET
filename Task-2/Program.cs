using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your Mark ( 0 - 100 ):");
        int Mark = int.Parse(Console.ReadLine());

        if (Mark > 100)
            Console.WriteLine("Please enter only [0, 100]");
        else if (Mark >= 90 && Mark <= 100)
            Console.WriteLine("Grade: A+");
        else if (Mark >= 80 && Mark <= 89)
            Console.WriteLine("Grade: A");
        else if (Mark >= 70 && Mark <= 79)
            Console.WriteLine("Grade: B");
        else
            Console.WriteLine("Grade: C or below");
    }
}


// 2. ქულების მიხედვით შეფასება (Grade Calculator)
// დავალება: დაწერე პროგრამა, რომელიც სტუდენტის ქულების მიხედვით ბეჭდავს შეფასებას.

// Input: marks (0–100)
// Output:

// 90 და მეტი → "Grade: A+"
// 80–89 → "Grade: A"
// 70–79 → "Grade: B"
// დანარჩენი → "Grade: C or below"