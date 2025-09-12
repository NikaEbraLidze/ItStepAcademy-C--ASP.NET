using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number one:");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter number two:");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter operator ( + , - , * , / ):");
        string op = Console.ReadLine();

        if (op == "+")
            Console.WriteLine(a + b);
        else if (op == "-")
            Console.WriteLine(a - b);
        else if (op == "*")
            Console.WriteLine(a * b);
        else if (op == "/")
            Console.WriteLine(a / b);
        else
            Console.WriteLine("Invalid operator!");
    }
}


// 8. კალკულატორი (Calculator Program)
// დავალება: დაწერე პროგრამა, რომელიც ორ რიცხვსა და ოპერატორს მიიღებს და შედეგს გამოითვლის.

// Input: a, b, op (მაგალითად "+", "-", "*", "/")
// Output: შესაბამისი გამოთვლის შედეგი.