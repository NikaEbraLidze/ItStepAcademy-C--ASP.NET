using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a username:");
        string username = Console.ReadLine();

        Console.Write("Enter a password:");
        string password = Console.ReadLine();

        if (username == "nikoloz" && password == "12345678")
            Console.WriteLine("Login Successful!");
        else
            Console.WriteLine("Invalid credentials!");
    }
}


// 1. ავტორიზაცია (Login Authentication)
// დავალება: დაწერე პროგრამა, რომელიც შეამოწმებს მომხმარებლის სახელსა და პაროლს.

// Input: username, password
// Output:

// თუ სწორია → "Login Successful!"
// თუ არასწორია → "Invalid credentials!"