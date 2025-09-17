using System;

class Program
{
    static void Main()
    {
        // 1. რიცხვების ბეჭდვა (Print Numbers 1–10)
        // დავალება: დაბეჭდე რიცხვები 1-იდან 10-მდე for ციკლით.
        // · Input: არაფერი
        // · Output: 1 2 3 4 5 6 7 8 9 10

        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.Write(i + " ");
        // }



        //2. რიცხვების ჯამი (Sum of Numbers 1–100)
        // დავალება: იპოვე რიცხვების ჯამი 1-დან 100-მდე.
        // · Input: არაფერი
        // · Output: "Sum = 5050"

        // int sum = 0;
        // for (int i = 1; i <= 100; i++)
        // {
        //     sum += i;
        //     if (i == 100)
        //         Console.Write("Sum = " + sum);
        // }



        // 3.კენტი რიცხვების ბეჭდვა(Odd Numbers)
        // დავალება: დაბეჭდე 1 - დან 20 - მდე ყველა კენტი რიცხვი.
        // · Input: არაფერი
        // · Output: 1 3 5 7... 19

        // for (int i = 1; i < 20; i += 2)
        // {
        //     Console.Write(i + " ");
        // }



        // 4. რიცხვის ტაბულა (Multiplication Table)
        // დავალება: დაბეჭდე 1 დან 9 მდე გამრავლების ტაბულა.

        // for (int i = 1; i < 10; i++)
        // {
        //     for (int b = 1; b < 10; b++)
        //     {
        //         Console.WriteLine($"{i} * {b} = {i * b}");
        //     }
        //     Console.WriteLine();
        // }

        // 5. უკუღმა ბეჭდვა (Reverse Numbers)
        // დავალება: დაბეჭდე რიცხვები 10-იდან 1-მდე.
        // Input: არაფერი
        // · Output: 10 9 8 ... 1

        // for (int i = 10; i >= 1; i--)
        // {
        //     Console.Write(i + " ");
        // }



        // 6. რიცხვის ფაქტორიალი (Factorial)
        // დავალება: გამოთვალე რიცხვის ფაქტორიალი n!.
        // · Input: n = 5
        // · Output: "Factorial = 120"

        // Console.Write("Enter Number: ");

        // int num = int.Parse(Console.ReadLine());
        // int factorial = 1;

        // for (int i = 1; i <= num; i++)
        // {
        //     factorial *= i;
        // }

        // Console.WriteLine($"Factorial = {factorial}");



        // 7. სიმბოლოს გამეორება (Repeat Character)
        // დავალება: დაბეჭდე "*" სიმბოლო 10-ჯერ ერთ ხაზზე.
        // · Input: არაფერი
        // · Output: "**********"

        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.Write("* ");
        // }



        // 8. While ციკლი – ჯამი სანამ არ გადავაჭარბებთ
        // დავალება: დაამატე რიცხვები სანამ ჯამი არ გახდება ≥ 50.
        // · Input: არაფერი
        // · Output: "Sum = 55"

        // int sum = 0;
        // int i = 0;

        // while (sum <= 50)
        // {
        //     sum += i;
        //     i++;
        // }

        // Console.WriteLine($"Sum = {sum}");



        // 9. Do-While ციკლი – პაროლი
        // დავალება: პროგრამამ პაროლი უნდა მოითხოვოს მანამდე, სანამ სწორს არ შეიყვანს.
        // · Input: "1234" (სწორი პაროლი)
        // · Output: "Enter password: ... Correct!"

        // Console.Write("Enter Password: ");
        // string password = Console.ReadLine();

        // do
        // {
        //     Console.Write("Enter Password: ");
        //     password = Console.ReadLine() ?? "";
        // } while (password != "1234");

        // Console.WriteLine("Correct!");



        // 12. რიცხვის პალინდრომი (Palindrome Number Check)
        // დავალება: შეამოწმე, არის თუ არა რიცხვი პალინდრომი (იგივე წაკითხვით წინ და უკან).
        // · Input: 121
        // · Output: "Palindrome"
        // · Input: 123
        // · Output: "Not Palindrome"

        // Console.Write("Enter Password: ");
        // string password = Console.ReadLine();


        // Console.Write("Enter a number: ");
        // int num = int.Parse(Console.ReadLine());
        // int original = num;
        // int reversed = 0;

        // while (num > 0)
        // {
        //     int digit = num % 10;
        //     reversed = reversed * 10 + digit;
        //     num /= 10;
        // }

        // if (reversed == original)
        //     Console.WriteLine("Palidrome");
        // else
        //     Console.WriteLine("Not Palidrome");


        // 13. რიცხვების ფიბონაჩის მიმდევრობა (Fibonacci Sequence)
        // დავალება: დაბეჭდე პირველი n ელემენტი ფიბონაჩის მიმდევრობიდან.
        // · Input: n = 7
        // · Output: 0 1 1 2 3 5 8


        // Console.Write("Enter a number: ");
        // int num = int.Parse(Console.ReadLine());

        // int lastLastNum = 0;
        // int lastNum = 1;

        // Console.Write($"{lastLastNum} {lastNum} ");

        // for (int i = 2; i < num; i++)
        // {
        //     int nextNum = lastLastNum + lastNum;
        //     Console.Write(nextNum + " ");

        //     lastLastNum = lastNum;
        //     lastNum = nextNum;
        // }
    }
}
