using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Mark (0 - 100):");
        int score = int.Parse(Console.ReadLine());

        if (score >= 50 && score <= 100)
            Console.WriteLine("Pass");
        else
            Console.WriteLine("Fail");
    }
}


// 7. სტუდენტის ჩაჭრა/ჩაბარება (Pass/Fail Result)
// დავალება: დაწერე პროგრამა, რომელიც სტუდენტის ქულას შეამოწმებს.

// Input: score (ქულა 0–100)
// Output:

// თუ ქულა ≥ 50 → "Pass"
// თუ ნაკლებია → "Fail"