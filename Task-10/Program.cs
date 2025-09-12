using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your role:");
        string role = Console.ReadLine();

        Console.Write("Enter your salary:");
        int salary = int.Parse(Console.ReadLine());

        if (role == "Manager" && salary > 2500)
            Console.WriteLine("bonus 15%");
        else if (role == "Manager" && salary <= 2500)
            Console.WriteLine("bonus 10%");
        else if (role == "Developer" && salary > 2000)
            Console.WriteLine("bonus 12%");
        else if (role == "Developer" && salary <= 2000)
            Console.WriteLine("bonus 8%");
        else
            Console.WriteLine("bonus 5%");
    }
}


// 10. თანამშრომლის ბონუსი (Employee Bonus Calculation)
// დავალება: დაწერე პროგრამა, რომელიც როლსა და ხელფასს მიიღებს და შესაბამის ბონუსს გამოთვლის.

// Input: role ("Manager", "Developer" ან სხვა), salary
// Output:

// თუ "Manager" და ხელფასი > 2500 → ბონუსი 15%, სხვანაირად 10%
// თუ "Developer" და ხელფასი > 2000 → ბონუსი 12%, სხვანაირად 8%
// სხვა შემთხვევაში → ბონუსი 5%