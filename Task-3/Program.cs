using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter purchase price:");
        long amount = long.Parse(Console.ReadLine());

        if (amount > 1000)
            Console.WriteLine("Sale = 10%");
        else
            Console.WriteLine("Sale = 5%");
    }
}


// 3. ფასდაკლების გამოთვლა (Discount Calculation)
// დავალება: დაწერე პროგრამა, რომელიც გამოითვლის ფასდაკლებას.

// Input: amount (შესაძენი თანხა)
// Output:

// თუ amount > 1000 → ფასდაკლება = 10%
// სხვა შემთხვევაში → ფასდაკლება = 5%