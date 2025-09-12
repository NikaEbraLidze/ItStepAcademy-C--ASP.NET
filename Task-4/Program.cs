using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number and we'll convert it to the day of the week:");
        byte num = byte.Parse(Console.ReadLine());

        if (num == 1)
            Console.WriteLine("Monday");
        else if (num == 2)
            Console.WriteLine("Tuesday");
        else if (num == 3)
            Console.WriteLine("Wednesday");
        else if (num == 4)
            Console.WriteLine("Thursday");
        else if (num == 5)
            Console.WriteLine("Friday");
        else if (num == 6)
            Console.WriteLine("Saturday");
        else if (num == 7)
            Console.WriteLine("Sunday");
        else
            Console.WriteLine("Invalid day number");
    }
}


// 4. კვირის დღეები (Day of the Week)
// დავალება: დაწერე პროგრამა, რომელიც რიცხვს გადააქცევს კვირის დღედ.

// Input: day (რიცხვი 1–7)
// Output: "Monday", "Tuesday" … "Sunday"

// სხვა რიცხვი → "Invalid day number"