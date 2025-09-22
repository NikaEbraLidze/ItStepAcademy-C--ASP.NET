using System;

class Program
{
    static void Main()
    {
        // დავალება 1

        // დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას.
        // მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის ნახევარ პირამიდა:
        // *
        // **
        // ***
        // ****






        // try
        // {
        //     Console.Write("შეიყვანეთ რიცხვი: ");
        //     int n = int.Parse(Console.ReadLine());

        //     if (n <= 0)
        //     {
        //         throw new Exception("რიცხვი უნდა იყოს დადებითი!");
        //     }

        //     // ციკლი ნახევარპირამიდისთვის
        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j <= i; j++)
        //         {
        //             Console.Write("*");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        // catch (FormatException)
        // {
        //     Console.WriteLine("შეიყვანეთ მხოლოდ რიცხვი!");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("შეცდომა: " + ex.Message);
        // }





        // დავალება 2
        // მომხმარებელს კლავიატურის გამოყენებით შეჰყავს 2 რიცხვი. ჩვენი ამოცანაა, რომ ვაჩვენოთ ყველა
        // ლუწი რიცხვი მითითებულ დიაპაზონში. თუ დიაპზონის საზღვრები არასწორად არის მოცემული, თქვენ უნდა
        // ჩაასწოროთ ის. მაგალითად, თუ მომხმარებელმა შეიყვანა 20 და 11, ჩასწორებაა საჭირო, რადგან დიაპაზონის
        // დასაწყისი უნდა იყოს - 11, და დასასრული - 20.

        // try
        // {
        //     Console.Write("შეიყვანეთ პირველი რიცხვი: ");
        //     int a = int.Parse(Console.ReadLine());

        //     Console.Write("შეიყვანეთ მეორე რიცხვი: ");
        //     int b = int.Parse(Console.ReadLine());

        //     // თუ დიაპაზონი არასწორადაა, შევცვალოთ
        //     if (a > b)
        //     {
        //         int temp = a;
        //         a = b;
        //         b = temp;
        //     }

        //     Console.WriteLine($"ლუწი რიცხვები {a}-დან {b}-მდე:");
        //     for (int i = a; i <= b; i++)
        //     {
        //         if (i % 2 == 0)
        //         {
        //             Console.Write(i + " ");
        //         }
        //     }
        // }
        // catch (FormatException)
        // {
        //     Console.WriteLine("შეიყვანეთ მხოლოდ რიცხვები!");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine("შეცდომა: " + ex.Message);
        // }






        // Exception
        // · კალკულატორის დავალება გადააწყეთ ისე რომ გამოიყენოთ Exception Handling, Try Catch და Throw


        bool correctInput = false; // სანამ ეს არ გახდება true, ციკლი იმუშავებს

        while (!correctInput)
        {
            try
            {
                Console.Write("შეიყვანეთ პირველი რიცხვი: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("შეიყვანეთ მოქმედება (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("შეიყვანეთ მეორე რიცხვი: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                if (op == "+")
                {
                    result = num1 + num2;
                }
                else if (op == "-")
                {
                    result = num1 - num2;
                }
                else if (op == "*")
                {
                    result = num1 * num2;
                }
                else if (op == "/")
                {
                    if (num2 == 0)
                    {
                        throw new Exception("ნულზე გაყოფა აკრძალულია!");
                    }
                    result = num1 / num2;
                }
                else
                {
                    throw new Exception("არასწორი ოპერაცია!");
                }

                Console.WriteLine("შედეგი: " + result);
                correctInput = true; // თუ აქამდე მოვედით, ყველაფერი სწორადაა => ციკლი მთავრდება
            }
            catch (FormatException)
            {
                Console.WriteLine("შეიყვანეთ მხოლოდ რიცხვები!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("შეცდომა: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("შეცდომა: " + ex.Message);
            }
        }
    }
}
