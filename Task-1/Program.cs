using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        try
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Bimi"),
                new Cat("mesi")
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {

            CheckingAccount acc1 = new CheckingAccount("GE12345678", 200m);
            CheckingAccount acc2 = new CheckingAccount("CHK002", 500m);
            LoanAccount loan1 = new LoanAccount("LN001", 2000m);

            TransactionService service = new TransactionService();
            service.Transfer(acc1, acc2, 100m);

            service.Transfer(acc2, loan1, 100m);

            service.Transfer(loan1, acc1, 100m);

        }
        catch (Exception ex)
        {
            Console.WriteLine($" error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n operation end");
        }
    }
}