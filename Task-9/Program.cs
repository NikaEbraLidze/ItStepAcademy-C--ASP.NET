using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age:");
        uint age = uint.Parse(Console.ReadLine());

        if (age <= 0)
            Console.WriteLine("Invalid age");
        else if (age >= 18)
            Console.WriteLine("Eligible to vote");
        else
            Console.WriteLine("Not eligible to vote");
    }
}


// 9. ხმის მიცემის უფლება (Voting Eligibility)
// დავალება: დაწერე პროგრამა, რომელიც ასაკის მიხედვით შეამოწმებს ხმის მიცემის უფლებას.

// Input: age
// Output:

// თუ ასაკი < 0 → "Invalid age"
// თუ ≥ 18 → "Eligible to vote"
// სხვა შემთხვევაში → "Not eligible to vote"