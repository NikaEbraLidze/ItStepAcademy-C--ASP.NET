using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Balance:");
        uint balance = uint.Parse(Console.ReadLine());

        Console.Write("Enter withdrawal:");
        uint withdrawal = uint.Parse(Console.ReadLine());

        if (withdrawal < 0)
            Console.WriteLine("Invalid withdrawal amount");
        else if (balance < withdrawal)
            Console.WriteLine("Insufficient balance");
        else
            Console.WriteLine($"Withdrawal successful! Remaining balance: {balance - withdrawal}");
    }
}


// 6. ბანკომატი (ATM Withdrawal Validation)
// დავალება: დაწერე პროგრამა, რომელიც თანხის გატანას ამოწმებს.

// Input: balance (ანგარიშზე თანხა), withdrawal (გასატანი თანხა)
// Output:

// თუ თანხა 0-ზე ნაკლებია → "Invalid withdrawal amount"
// თუ თანხა მეტია ბალანსზე → "Insufficient balance"
// სხვა შემთხვევაში → "Withdrawal successful! Remaining balance: ..."